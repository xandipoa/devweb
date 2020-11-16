using FI.AtividadeEntrevista.BLL;
using WebAtividadeEntrevista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FI.AtividadeEntrevista.DML;
using FI.AtividadeEntrevista.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebAtividadeEntrevista.Controllers
{
    public class BeneficiarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Incluir(BeneficiarioModel model)
        {
            BoBeneficiario bo = new BoBeneficiario();
            
            if (!this.ModelState.IsValid)
            {
                List<string> erros = (from item in ModelState.Values
                                      from error in item.Errors
                                      select error.ErrorMessage).ToList();

                Response.StatusCode = 400;
                return Json(string.Join(Environment.NewLine, erros));
            }
            else
            {
                ///Remover os caracteres não numéricos
                string cpfCompleto = model.CPF;
                string cpfBasico = cpfCompleto.Replace(".", "").Replace("-", "");

                bool cpfCadastrado = bo.VerificarExistencia(cpfBasico);

                if (!cpfCadastrado)
                {
                    model.Id = bo.Incluir(new Beneficiario()
                    {
                        Nome = model.Nome,
                        CPF = cpfBasico,
                        IdCliente = model.IdCliente
                    });
                }
                else
                    return Json("CPF já cadastrado!");


                return Json("Cadastro efetuado com sucesso");
            }
        }

        [HttpPost]
        public JsonResult Alterar(BeneficiarioModel model)
        {
            BoBeneficiario bo = new BoBeneficiario();
       
            if (!this.ModelState.IsValid)
            {
                List<string> erros = (from item in ModelState.Values
                                      from error in item.Errors
                                      select error.ErrorMessage).ToList();

                Response.StatusCode = 400;
                return Json(string.Join(Environment.NewLine, erros));
            }
            else
            {
                ///Remover os caracteres não numéricos
                string cpfCompleto = model.CPF;
                string cpfBasico = cpfCompleto.Replace(".", "").Replace("-", "");

                bool cpfCadastrado = bo.VerificarExistencia(cpfBasico);

                if (!cpfCadastrado)
                {
                    bo.Alterar(new Beneficiario()
                    {
                        Id = model.Id,                   
                        CPF = cpfBasico,
                        IdCliente = model.IdCliente
                    });
                }
                else
                    return Json("CPF já cadastrado!");

                return Json("Cadastro alterado com sucesso");
            }
        }

        [HttpGet]
        public ActionResult Alterar(long id)
        {
            BoBeneficiario bo = new BoBeneficiario();
            Beneficiario cliente = bo.Consultar(id);
            Models.BeneficiarioModel model = null;

            if (cliente != null)
            {
                model = new BeneficiarioModel()
                {
                    Id = cliente.Id,                    
                    CPF = cliente.CPF,
                    IdCliente = cliente.IdCliente
                };

            
            }

            return View(model);
        }

        [HttpPost]
        public JsonResult Deletar(long Id)
        {
            BoBeneficiario bo = new BoBeneficiario();

            if (!this.ModelState.IsValid)
            {
                List<string> erros = (from item in ModelState.Values
                                      from error in item.Errors
                                      select error.ErrorMessage).ToList();

                Response.StatusCode = 400;
                return Json(string.Join(Environment.NewLine, erros));
            }
            else
            {
                bo.Excluir(Id);               

                return Json("Excluído com sucesso");
            }
        }


        [HttpPost]
        public JsonResult ClienteList(int jtStartIndex = 0, int jtPageSize = 0, string jtSorting = null)
        {
            try
            {
                int qtd = 0;
                string campo = string.Empty;
                string crescente = string.Empty;
                string[] array = jtSorting.Split(' ');

                if (array.Length > 0)
                    campo = array[0];

                if (array.Length > 1)
                    crescente = array[1];

                List<Beneficiario> clientes = new BoBeneficiario().Pesquisa(jtStartIndex, jtPageSize, campo, crescente.Equals("ASC", StringComparison.InvariantCultureIgnoreCase), out qtd);
                
                //Return result to jTable
                return Json(new { Result = "OK", Records = clientes, TotalRecordCount = qtd });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }        
    }
}