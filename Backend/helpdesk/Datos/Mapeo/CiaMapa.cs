using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    public class CiaMapa : IEntityTypeConfiguration<Cia>
    {
        public void Configure(EntityTypeBuilder<Cia> builder)
        {
            builder
                .HasKey(x => x.cia_id);

            builder
                .ToTable("cia");

            builder
                .HasIndex(i => i.nombre)
                .IsUnique();

            builder
                .HasIndex(i => i.rif)
                .IsUnique();

            builder
                .Property(p => p.rif)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(p => p.nombre)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(p => p.version_app)
                .HasMaxLength(8)
                .IsRequired();

            builder
                .Property(p => p.marca)
                .HasMaxLength(60);

            builder
                .Property(p => p.codigo_bd)
                .HasMaxLength(12)
                .IsRequired();

            builder
                .Property(p => p.version_bd)
                .HasMaxLength(8)
                .IsRequired();

            builder
                .HasOne(a => a.grupoCia)
                .WithMany(b => b.cias)
                .HasForeignKey(c => c.grupo_cia_id)
                .HasConstraintName("fk_cia_grupoCia")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.pais)
                .WithMany(b => b.cias)
                .HasForeignKey(c => c.pais_id)
                .HasConstraintName("fk_cia_pais")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.tipo166)
                .WithMany(y => y.ciasTipo)
                .HasForeignKey(z => z.tipo_166_id)
                .HasConstraintName("fk_cia_dd_166")
                .OnDelete(DeleteBehavior.Restrict);


            builder
              .HasOne(a => a.marca87)
              .WithMany(b => b.ciasMarca)
              .HasForeignKey(c => c.marca_87_id)
              .HasConstraintName("fk_cia_dd_marca87")
              .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.soporte)
                .WithMany(b => b.cias)
                .HasForeignKey(c => c.soporte_id)
                .HasConstraintName("fk_cia_soporte")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.ciudad)
                .WithMany(b => b.cias)
                .HasForeignKey(c => c.ciudad_id)
                .HasConstraintName("fk_cia_ciudad")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.estado)
                .WithMany(b => b.cias)
                .HasForeignKey(c => c.estado_id)
                .HasConstraintName("fk_cia_estado")
                .OnDelete(DeleteBehavior.Restrict);







        }
    }
}
