using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class HdDocMapa : IEntityTypeConfiguration<HdDoc>
    {
        public void Configure(EntityTypeBuilder<HdDoc> builder)
        {
            builder
                .HasKey(x => x.hd_doc_id);

            builder
                .ToTable("hddoc");

            builder
                .Property(o => o.titulo)
                .HasMaxLength(120)
                .IsRequired();

            builder
                .Property(o => o.descripcion)
                .HasColumnType("text")
                .IsRequired();

            builder
                .Property(o => o.version_app)
                .HasMaxLength(12);

            builder
                .Property(o => o.version_bd)
                .HasMaxLength(12);

            builder
                .Property(o => o.solucion)
                .HasColumnType("text");

            builder
                .Property(o => o.version_solucion)
                .HasMaxLength(12);

            builder
                .Property(o => o.nombre_contacto)
                .HasMaxLength(120);

            builder
                .Property(o => o.email_contacto)
                .HasMaxLength(150);

            builder
                .Property(o => o.tlf_contacto)
                .HasMaxLength(20);

            builder
                .Property(o => o.nombre_ventana)
                .HasMaxLength(60);



            // Usuarios
            builder
                .HasOne(a => a.consultor)
                .WithMany(b => b.hdConsultores)
                .HasForeignKey(c => c.consultor_id)
                .HasConstraintName("fk_hddoc_consultor")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.programador)
                .WithMany(b => b.hdProgramadores)
                .HasForeignKey(c => c.programador_id)
                .HasConstraintName("fk_hddoc_programador")
                .OnDelete(DeleteBehavior.Restrict);


            //
            builder
                .HasOne(a => a.cia)
                .WithMany(b => b.hdDocs)
                .HasForeignKey(c => c.cia_id)
                .HasConstraintName("fk_hddoc_cia")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.persona)
                .WithMany(b => b.hdDocs)
                .HasForeignKey(c => c.programador_id)
                .HasConstraintName("fk_hddoc_persona")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.pais)
                .WithMany(b => b.hdDocs)
                .HasForeignKey(c => c.pais_id)
                .HasConstraintName("fk_hddoc_pais")
                .OnDelete(DeleteBehavior.Restrict);


            // DominiosDet
            builder
                .HasOne(a => a.aplicacion178)
                .WithMany(b => b.hdAplicaciones178)
                .HasForeignKey(c => c.aplicacion_178_id)
                .HasConstraintName("fk_hddoc_dd_aplicacion178")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.urgencia170)
                .WithMany(b => b.hdUrgencias170)
                .HasForeignKey(c => c.urgencia_170_id)
                .HasConstraintName("fk_hddoc_dd_consultor")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.tipo172)
                .WithMany(b => b.hdTipo172)
                .HasForeignKey(c => c.tipo_172_id)
                .HasConstraintName("fk_hddoc_dd_tipo172")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.status175)
                .WithMany(b => b.hdStatus175)
                .HasForeignKey(c => c.status_175_id)
                .HasConstraintName("fk_hddoc_dd_status175")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.modulo214)
                .WithMany(b => b.hdModulo214)
                .HasForeignKey(c => c.modulo_214_id)
                .HasConstraintName("fk_hddoc_dd_modulo214")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.motivo298)
                .WithMany(b => b.hdMotivos298)
                .HasForeignKey(c => c.motivo_298_id)
                .HasConstraintName("fk_hddoc_dd_motivo298")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
