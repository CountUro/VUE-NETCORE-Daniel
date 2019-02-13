using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class HdArchivoMapa : IEntityTypeConfiguration<HdArchivo>
    {
        public void Configure(EntityTypeBuilder<HdArchivo> builder)
        {
            builder
                .HasKey(x => x.hd_archivo_id);

            builder
                .ToTable("hdarchivo");

            builder
                .Property(o => o.descripcion)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .Property(o => o.nombrefile)
                .HasMaxLength(250)
                .IsRequired();

            builder
                .HasOne(a => a.hdDoc)
                .WithMany(b => b.hdArchivos)
                .HasForeignKey(c => c.hd_doc_id)
                .HasConstraintName("fk_hdarchivo_hddoc")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.usuario)
                .WithMany(b => b.hdArchivos)
                .HasForeignKey(c => c.usuario_id)
                .HasConstraintName("fk_hdarchivo_usuario")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
