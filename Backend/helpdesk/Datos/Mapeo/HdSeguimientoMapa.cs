using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class HdSeguimientoMapa : IEntityTypeConfiguration<HdSeguimiento>
    {
        public void Configure(EntityTypeBuilder<HdSeguimiento> builder)
        {
            builder
                .HasKey(x => x.hd_seguimiento_id);

            builder
                .ToTable("hdseguimiento");

            builder
                .Property(o => o.observaciones)
                .HasColumnType("text")
                .IsRequired();

            //
            builder
                .HasOne(a => a.hdDoc)
                .WithMany(b => b.hdSeguimientos)
                .HasForeignKey(c => c.hd_doc_id)
                .HasConstraintName("fk_hdseguimiento_hddoc")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.usuario)
                .WithMany(b => b.hdSeguimientos)
                .HasForeignKey(c => c.usuario_id)
                .HasConstraintName("fk_hdseguimiento_usuario")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.status175)
                .WithMany(b => b.hdSeguimientos)
                .HasForeignKey(c => c.status_175_id)
                .HasConstraintName("fk_hdseguimiento_dd_status175")
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
