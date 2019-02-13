using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class MunicipioMapa : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder
                .HasKey(x => x.municipio_id);

            builder
                .ToTable("municipio");

            builder
                .Property(o => o.nombre)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(o => o.estado_id)
                .IsRequired();

            builder
                .Property(o => o.codigo)
                .HasMaxLength(6);

            builder
                .Property(o => o.referencia)
                .HasMaxLength(6);

            builder
                .HasIndex(i => new { i.estado_id, i.nombre })
                .IsUnique();


            //
            builder
                .HasOne(a => a.estado)
                .WithMany(b => b.municipios)
                .HasForeignKey(c => c.estado_id)
                .HasConstraintName("fk_municipio_estado")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
