using AnthonyCoronadoIpanaqué.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthonyCoronadoIpanaqué.DB.Configuracion
{
    public class DetalleNotaTagsConfiguracion : IEntityTypeConfiguration<DetalleNotaTags>
    {
        public void Configure(EntityTypeBuilder<DetalleNotaTags> builder)
        {
            builder.ToTable("DetalleNotaTags");
            builder.HasKey(x => x.Id);

            builder.HasOne(a => a.Tag).WithMany(a => a.DetalleNotaTags).
                HasForeignKey(a => a.IdTags);

            builder.HasOne(o => o.Nota).WithMany(o => o.DetalleNotaTags)
                .HasForeignKey(o => o.IdNota);
        }
    }
}
