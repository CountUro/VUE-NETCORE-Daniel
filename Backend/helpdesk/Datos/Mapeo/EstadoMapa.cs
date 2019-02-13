using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class EstadoMapa : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder
                .HasKey(x => x.estado_id);

            builder
                .ToTable("estado");

            builder
                .HasIndex(o => new { o.pais_id, o.nombre })
                .IsUnique();

            builder
                .Property(o => o.nombre)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .Property(o => o.codigo)
                .HasMaxLength(6);

            builder
                .HasOne(a => a.pais)
                .WithMany(b => b.estados)
                .HasForeignKey(c => c.pais_id)
                .HasConstraintName("fk_estado_pais")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
