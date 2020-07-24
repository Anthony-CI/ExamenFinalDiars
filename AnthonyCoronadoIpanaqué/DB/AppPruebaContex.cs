using AnthonyCoronadoIpanaqué.DB.Configuracion;
using AnthonyCoronadoIpanaqué.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthonyCoronadoIpanaqué.DB
{
    public class AppPruebaContex : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<DetalleNotaTags> DetalleNotaTages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ExamenFinal;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioConfiguracion());
            modelBuilder.ApplyConfiguration(new DetalleNotaTagsConfiguracion());
            modelBuilder.ApplyConfiguration(new TagConfiguracion());
            modelBuilder.ApplyConfiguration(new NotaConfiguracion());
        }
    }
}
