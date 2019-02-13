using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class CiudadMapa : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder
                .HasKey(x => x.ciudad_id);

            builder
                .ToTable("ciudad");

            builder
                .HasIndex(i => new { i.estado_id, i.nombre })
                .IsUnique();

            builder
                .Property(o => o.nombre)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .Property(o => o.codigo)
                .HasMaxLength(6);

            builder
                .HasOne(a => a.estado)
                .WithMany(b => b.ciudades)
                .HasForeignKey(c => c.estado_id)
                .HasConstraintName("fk_ciudad_estado")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
