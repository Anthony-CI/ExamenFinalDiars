using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnthonyCoronadoIpanaqué.DB;
using Microsoft.AspNetCore.Mvc;

namespace AnthonyCoronadoIpanaqué.Controllers
{
    public class SearchController : Controller
    {
        private AppPruebaContex context = new AppPruebaContex();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult _Index(string busqueda)
        {
            var query = context.Notas.AsQueryable();
            var queryq = context.Tags.AsQueryable();

            if (!string.IsNullOrEmpty(busqueda))
            {
                query = query.Where(a => a.Titulo.Contains(busqueda)).Take(5);

            }
            if (!string.IsNullOrEmpty(busqueda))
            {
                queryq = queryq.Where(a => a.Nombre.Contains(busqueda)).Take(5);

            }
            ViewBag.que = queryq;
            query.ToList();
            return View(query);
        }
    }
}