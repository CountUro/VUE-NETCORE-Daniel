using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class DominioDetMapa : IEntityTypeConfiguration<DominioDet>
    {
        public void Configure(EntityTypeBuilder<DominioDet> builder)
        {
            builder
                .HasKey(x => x.dominio_det_id);

            builder
                .ToTable("dominio_det");

            builder.Property(o => o.dominio_det_id).ValueGeneratedNever();

            builder
                .Property(o => o.codigo)
                .HasDefaultValue(0)
                .IsRequired();

            builder
                .Property(o => o.descripcion)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(o => o.descrip_corta)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Property(o => o.signo)
                .HasDefaultValue(0)
                .IsRequired();

            builder
                .Property(o => o.entero1)
                .IsRequired();

            builder
                .Property(o => o.entero2)
                .IsRequired();

            builder
                .Property(o => o.pais_id)
                .IsRequired();

            builder
                .Property(o => o.dominio_id)
                .IsRequired();

            builder
                .HasIndex(o => new { o.dominio_id, o.pais_id, o.codigo })
                .IsUnique();

            builder
               .HasIndex(o => new { o.dominio_id, o.pais_id, o.descripcion })
               .IsUnique();



            builder
                .HasOne(a => a.dominio)
                .WithMany(b => b.dominiosDet)
                .HasForeignKey(c => c.dominio_id)
                .HasConstraintName("fk_dominiodet_dominio")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.pais)
                .WithMany(b => b.dominiosDet)
                .HasForeignKey(c => c.pais_id)
                .HasConstraintName("fk_dominiodet_pais")
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
