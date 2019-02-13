using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class SoporteMapa : IEntityTypeConfiguration<Soporte>
    {
        public void Configure(EntityTypeBuilder<Soporte> builder)
        {
            builder
                .HasKey(x => x.soporte_id);

            builder
                .ToTable("soporte");

            builder
                .Property(o => o.nombre)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasIndex(a => a.nombre)
                .IsUnique();
        }
    }
}