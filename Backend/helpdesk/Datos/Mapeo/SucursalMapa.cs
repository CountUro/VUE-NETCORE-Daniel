using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class SucursalMapa : IEntityTypeConfiguration<Sucursal>
    {
        public void Configure(EntityTypeBuilder<Sucursal> builder)
        {
            builder
                .HasKey(x => x.sucursal_id);

            builder
                .ToTable("sucursal");

            builder
                .Property(o => o.nombre)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasIndex(i => new { i.cia_id, i.nombre })
                .IsUnique();

            builder
                .HasOne(a => a.cia)
                .WithMany(b => b.sucursales)
                .HasForeignKey(c => c.cia_id)
                .HasConstraintName("fk_sucursal_cia")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.pais)
                .WithMany(b => b.sucursales)
                .HasForeignKey(c => c.pais_id)
                .HasConstraintName("fk_sucursal_pais")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.estado)
                .WithMany(b => b.sucursales)
                .HasForeignKey(c => c.estado_id)
                .HasConstraintName("fk_sucursal_estado")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.ciudad)
                .WithMany(b => b.sucursales)
                .HasForeignKey(c => c.ciudad_id)
                .HasConstraintName("fk_sucursal_ciudad")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.municipio)
                .WithMany(b => b.sucursales)
                .HasForeignKey(c => c.municipio_id)
                .HasConstraintName("fk_sucursal_municipio")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}