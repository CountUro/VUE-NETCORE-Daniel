using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Mapeo
{
    class ConsecutivoHdMapa : IEntityTypeConfiguration<ConsecutivoHd>
    {
        public void Configure(EntityTypeBuilder<ConsecutivoHd> builder)
        {
            builder
                .HasKey(x => x.consecutivo_hd_id);

            builder
            .Property(o => o.consecutivo_hd_id)
            .ValueGeneratedNever()
            .IsRequired();

            builder
                .ToTable("consecutivo_hd");

        }
    }
}