using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CADASTRO.Modelos.Contexto;
using CADASTRO.Modelos.Entidades;

namespace CADASTRO.Controllers
{    
    public class CidadesController : Controller
    {
        private readonly Contexto _contexto;

        public CidadesController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var lista = _contexto.Cidade.ToList();
            CarregaUfCidade();
            return View(lista);
        }

               
        [HttpGet]
        public IActionResult Create()
        {
            var cidade = new Cidade();
            CarregaUfCidade();
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
            CarregaUfCidade();
            return View(cidade);
        }
                
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var cidade = _contexto.Cidade.Find(Id);
            CarregaUfCidade();
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
                CarregaUfCidade();
                return View(cidade);
            }           
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cidade = _contexto.Cidade.Find(Id);
            CarregaUfCidade();
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
            CarregaUfCidade();
            return View(cidade);
        }

        public void CarregaUfCidade()
        {
            var ListaUf = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text = "AC"},
                new SelectListItem{ Value = "2", Text = "AL"},
                new SelectListItem{ Value = "3", Text = "AP"},
                new SelectListItem{ Value = "4", Text = "AM"},
                new SelectListItem{ Value = "5", Text = "BA"},
                new SelectListItem{ Value = "6", Text = "CE"},
                new SelectListItem{ Value = "7", Text = "DF"},
                new SelectListItem{ Value = "8", Text = "ES"},
                new SelectListItem{ Value = "9", Text = "GO"},
                new SelectListItem{ Value = "10", Text = "MA"},
                new SelectListItem{ Value = "11", Text = "MT"},
                new SelectListItem{ Value = "12", Text = "MS"},
                new SelectListItem{ Value = "13", Text = "MG"},
                new SelectListItem{ Value = "14", Text = "PA"},
                new SelectListItem{ Value = "15", Text = "PB"},
                new SelectListItem{ Value = "16", Text = "PR"},
                new SelectListItem{ Value = "17", Text = "PE"},
                new SelectListItem{ Value = "18", Text = "PI"},
                new SelectListItem{ Value = "19", Text = "RJ"},
                new SelectListItem{ Value = "20", Text = "RN"},
                new SelectListItem{ Value = "21", Text = "RS"},
                new SelectListItem{ Value = "22", Text = "RO"},
                new SelectListItem{ Value = "23", Text = "RR"},
                new SelectListItem{ Value = "24", Text = "SC"},
                new SelectListItem{ Value = "25", Text = "SP"},
                new SelectListItem{ Value = "26", Text = "SE"},
                new SelectListItem{ Value = "27", Text = "TO"}
            };

            ViewBag.UfCidade = ListaUf;
        }     
        
    }
}
