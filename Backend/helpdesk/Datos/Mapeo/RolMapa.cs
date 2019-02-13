using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class RolMapa : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder
                .HasKey(x => x.rol_id);

            builder
                .ToTable("rol");

            builder
                .HasIndex(p => p.nombre)
                .IsUnique();

            builder
                .Property(o => o.nombre)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}