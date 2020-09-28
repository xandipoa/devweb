using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro.Models.Contexto;
using Cadastro.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cadastro.Services;

namespace Cadastro.Controllers
{
    public class CidadeController : Controller
    {
        private readonly Contexto _contexto;


        public CidadeController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
           
            try
            {
                List<Cidade> lista = new List<Cidade>();
                lista = _contexto.Cidade.ToList();
                ViewBag.Estados = EstadoService.GetEstados().Select(c => new SelectListItem()
                { Text = c.EstadoNome, Value = c.EstadoSigla }).ToList();
                return View(lista);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return (IActionResult)ex;
            }
        }


        [HttpGet]
        public IActionResult Create()
        {
            var cidade = new Cidade();
            ViewBag.Estados = EstadoService.GetEstados().Select(c => new SelectListItem()
            { Text = c.EstadoNome, Value = c.EstadoSigla }).ToList();
            return View(cidade);
        }

        [HttpPost]
        public IActionResult Create(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                _contexto.Cidade.Add(cidade);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewBag.Estados = EstadoService.GetEstados().Select(c => new SelectListItem()
            { Text = c.EstadoNome, Value = c.EstadoSigla }).ToList();
            return View(cidade);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var cidade = _contexto.Cidade.Find(Id);
            ViewBag.Estados = EstadoService.GetEstados().Select(c => new SelectListItem()
            { Text = c.EstadoNome, Value = c.EstadoSigla }).ToList();
            return View(cidade);
        }

        [HttpPost]
        public IActionResult Edit(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                _contexto.Cidade.Update(cidade);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Estados = EstadoService.GetEstados().Select(c => new SelectListItem()
                { Text = c.EstadoNome, Value = c.EstadoSigla }).ToList();
                return View(cidade);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cidade = _contexto.Cidade.Find(Id);
            ViewBag.Estados = EstadoService.GetEstados().Select(c => new SelectListItem()
            { Text = c.EstadoNome, Value = c.EstadoSigla }).ToList();
            return View(cidade);
        }

        [HttpPost]
        public IActionResult Delete(Cidade _cidade)
        {
            var cidade = _contexto.Cidade.Find(_cidade.Id);

            if (cidade != null)
            {
                _contexto.Cidade.Remove(cidade);
                _contexto.SaveChanges();

                return RedirectToAction("Index");

            }
            return View(cidade);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var cidade = _contexto.Cidade.Find(Id);
            ViewBag.Estados = EstadoService.GetEstados().Select(c => new SelectListItem()
            { Text = c.EstadoNome, Value = c.EstadoSigla }).ToList();
            return View(cidade);
        }       
    }
    
}
