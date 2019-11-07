using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.ClienteId);

            builder.Property(e => e.CPF)
               .HasColumnType("varchar(11)")
               .IsRequired();

            builder.Property(e => e.Nome)
               .HasColumnType("varchar(200)")
               .IsRequired();
        }
    }
}