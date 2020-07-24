using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnthonyCoronadoIpanaqué.DB;
using AnthonyCoronadoIpanaqué.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace AnthonyCoronadoIpanaqué.Controllers
{
    public class NotaController : Controller
    {
        private AppPruebaContex context = new AppPruebaContex();



        public IActionResult Index()
        {


            var postss = context.Notas.OrderByDescending(a => a.Fecha).ToList();

            var totalPosts = context.Notas.Count();

            var model = new IndexViewModel();
            model.Notas = postss;

            model.TotalRegistros = totalPosts;

            model.ValoresQueryString = new RouteValueDictionary();

            ViewBag.tagsDelPost = context.Tags.ToList();
            ViewBag.detalle = context.DetalleNotaTages.ToList();
            ViewBag.posts = postss;
            ViewBag.model = model;
            return View(model);
        }


        public IActionResult VerDetalle(int id)
        {
            ViewBag.posts = context.Notas.Where(a => a.Id == id).ToList();
            ViewBag.tagsDelPost = context.Notas.ToList();
            ViewBag.detalle = context.DetalleNotaTages.ToList();
            return View();
        }



        [HttpGet]
        public IActionResult Crear()
        {
            var categorias = context.Tags.ToList();
            ViewBag.cat = categorias;
            return View(new Nota());
        }

        [HttpPost]
        public IActionResult Crear(Nota nota, List<int> tags)
        {
            var categorias = context.Tags.ToList();
            ViewBag.cat = categorias;
            //validar(nota);

            if (ModelState.IsValid)
            {
                var fechita = DateTime.Now;
                nota.Fecha = fechita;
                context.Add(nota);
                context.SaveChanges();
                //Agregar tags
                var postss = context.Notas.First(o => o.Titulo == nota.Titulo);

                foreach (var tagc in tags)
                {
                    var detalle = new DetalleNotaTags(postss.Id, tagc);
                    context.Add(detalle);
                    context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        public void validar(Nota nota)
        {
            if (nota.Titulo.Length >= 200)
            {
                ModelState.AddModelError("Titulo", "Cantidad de caracteres no soportado");
            }
        }


        //eliminar
        public IActionResult EliminarNota(int IdEliminar)
        {
            var eliminarNota = context.Notas.First(o => o.Id == IdEliminar);
            context.Notas.Remove(eliminarNota);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        //editar

        [HttpGet]
        public ViewResult Editar(int id)
        {
            var context = new AppPruebaContex();
            var te = context.Notas.Where(o => o.Id == id).First();

            return View(te);
        }

        [HttpPost]
        public IActionResult Editar(Nota nota)
        {
            var context = new AppPruebaContex();


            var userDB = context.Notas.Where(o => o.Id == nota.Id).First();
            userDB.Titulo = nota.Titulo;
            userDB.Titulo = nota.Contenido;

            context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}