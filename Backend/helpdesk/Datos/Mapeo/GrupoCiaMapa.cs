using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class GrupoCiaMapa : IEntityTypeConfiguration<GrupoCia>
    {
        public void Configure(EntityTypeBuilder<GrupoCia> builder)
        {
            builder
                .HasKey(x => x.grupo_cia_id);

            builder
                .ToTable("grupo_cia");

            builder
                .HasIndex(o => o.nombre)
                .IsUnique();

            builder
                .Property(o => o.nombre)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
