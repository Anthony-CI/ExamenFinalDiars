using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthonyCoronadoIpanaqué.Models
{
    public class BaseModelo
    {
        public int PaginaActual { get; set; }
        public int TotalRegistros { get; set; }
        public int RegistroPorPagina { get; set; }
        public RouteValueDictionary ValoresQueryString { get; set; }
    }
}
