using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthonyCoronadoIpanaqué.Models
{
    public class DetalleNotaTags
    {
        public int Id { get; set; }
        public int IdNota { get; set; }
        public int IdTags { get; set; }
        public Tag Tag { get; set; }
        public Nota Nota { get; set; }
        public DetalleNotaTags()
        {
        }
        public DetalleNotaTags(int idNota, int idTags)
        {
            this.IdNota = idNota;
            this.IdTags = idTags;
        }
    }
}
