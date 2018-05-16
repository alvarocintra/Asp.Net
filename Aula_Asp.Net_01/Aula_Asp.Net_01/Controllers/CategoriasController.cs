using Aula_Asp.Net_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula_Asp.Net_01.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();
            categorias.Add(
                new Categoria()
                {
                    Nome = "Estudo"
                }
                );
            categorias.Add(new Categoria() { Nome = "Casa" });
            categorias.Add(new Categoria() { Nome = "Carro" });
            categorias.Add(new Categoria() { Nome = "Trabalho" });

            ViewBag.Categorias = categorias;

            return View();
        }
    }
}