using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class DominioMapa : IEntityTypeConfiguration<Dominio>
    {
        public void Configure(EntityTypeBuilder<Dominio> builder)
        {
            builder
                .HasKey(x => x.dominio_id);

            builder
                .Property(o => o.dominio_id)
                .ValueGeneratedNever()
                .IsRequired();

            builder
                .Property(o => o.descripcion)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasIndex(o => o.descripcion).IsUnique();

            builder
                .ToTable("dominio");
        }
    }
}