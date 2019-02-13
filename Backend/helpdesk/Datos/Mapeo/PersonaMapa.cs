using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class PersonaMapa : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder
                .HasKey(x => x.persona_id);

            builder
                .ToTable("persona");

            builder
                .HasIndex(o => o.cedula)
                .IsUnique();

            builder
                .Property(o => o.cedula)
                .HasMaxLength(15)
                .IsRequired();

            builder
                .Property(o => o.nombre1)
                .HasMaxLength(200)
                .IsRequired();

            builder
                .Property(o => o.nombre_comp)
                .HasMaxLength(200)
                .IsRequired();

            builder
                .Property(o => o.nombre2)
                .HasMaxLength(100);

            builder
                .Property(o => o.apellido1)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(o => o.apellido2)
                .HasMaxLength(100);

            builder
                .Property(o => o.tlf_local)
                .HasMaxLength(20);

            builder
                .Property(o => o.tlf_movil)
                .HasMaxLength(20);

            builder
                .Property(o => o.email)
                .HasMaxLength(150);

            builder
                .Property(o => o.cargo)
                .HasMaxLength(60);


            builder
                .HasOne(a => a.sexo6)
                .WithMany(b => b.personasSexo)
                .HasForeignKey(c => c.sexo_6_id)
                .HasConstraintName("fk_persona_dd_sexo6")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
