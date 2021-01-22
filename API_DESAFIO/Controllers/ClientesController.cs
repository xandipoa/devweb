using API_DESAFIO.Context;
using API_DESAFIO.Models;
using CsvHelper.Configuration.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_DESAFIO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;
        
        public ClientesController(AppDbContext contexto)
        {
            _context = contexto;
        }

        //Lista todos os clientes
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return _context.Clientes.ToList();
        }        

        //Consulta por CPF
        [HttpGet("{cpf}", Name = "ObterCliente")]
        public ActionResult<Cliente> Get(string cpf)
        {
            var cliente = _context.Clientes.FirstOrDefault(p => p.Cpf == cpf);
            if (cliente == null)
            {
                return NotFound();
            }
            return cliente;
        }

        //Adiciona um cliente
        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterCliente",
                new { cpf = cliente.Cpf}, cliente);
        }

        //Altera um cliente
        [HttpPut("{cpf}")]
        public ActionResult Put(string cpf, [FromBody] Cliente cliente)
        {
            if ( cpf != cliente.Cpf)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }

        //Exclui um cliente
        [HttpDelete("{cpf}")]
        public ActionResult<Cliente> Delete(string cpf)
        {
            var cliente = _context.Clientes.FirstOrDefault(p => p.Cpf == cpf);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }
    }
}
