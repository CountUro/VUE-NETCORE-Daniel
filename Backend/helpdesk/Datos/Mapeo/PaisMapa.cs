using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class PaisMapa : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder
                .HasKey(x => x.pais_id);

            builder
                .ToTable("pais");

            builder
                .Property(o => o.pais_id)
                .ValueGeneratedNever()
                .IsRequired();

            builder
                .HasIndex(o => o.nombre)
                .IsUnique();

            builder
                .Property(o => o.nombre)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .Property(o => o.nombre_completo)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .Property(o => o.continente)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(o => o.iso2)
                .HasMaxLength(4)
                .IsRequired();

            builder
                .Property(o => o.iso3)
                .HasMaxLength(4)
                .IsRequired();

            builder
                .Property(o => o.iso3166)
                .HasMaxLength(4)
                .IsRequired();

            builder
                .Property(o => o.cia)
                .HasMaxLength(10)
                .IsRequired();

            builder
                .Property(o => o.telefono)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(o => o.internet)
                .HasMaxLength(4)
                .IsRequired();

            builder
                .Property(o => o.vehiculo)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}