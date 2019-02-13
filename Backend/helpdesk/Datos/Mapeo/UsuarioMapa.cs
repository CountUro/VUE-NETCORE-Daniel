using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class UsuarioMapa : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .HasKey(x => x.usuario_id);

            builder
                .ToTable("usuario");

            builder
                .Property(o => o.nombre)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(o => o.token)
                .HasMaxLength(1024);

            builder
                .Property(o => o.email)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .HasIndex(i => i.email)
                .IsUnique();

            builder
                .Property(o => o.tlf_movil)
                .HasMaxLength(20);

            builder
                .Property(o => o.tlf_oficina)
                .HasMaxLength(20);

            builder
                .Property(o => o.password_hash)
                .IsRequired();

            builder
                .Property(o => o.password_salt)
                .IsRequired();


            //
            builder
                .HasOne(a => a.soporte)
                .WithMany(b => b.usuarios)
                .HasForeignKey(c => c.soporte_id)
                .HasConstraintName("fk_usuario_soporte")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.pais)
                .WithMany(b => b.usuarios)
                .HasForeignKey(c => c.pais_id)
                .HasConstraintName("fk_usuario_pais")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.rol)
                .WithMany(b => b.usuarios)
                .HasForeignKey(c => c.rol_id)
                .HasConstraintName("fk_usuario_rol")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}