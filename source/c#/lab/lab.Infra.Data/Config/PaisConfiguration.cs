using lab.Domain.Entities.Cadastro.Auxiliar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace lab.Infra.Data.Config
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.HasKey(pf => pf.Id);
            builder.Property(pf => pf.Nome).HasMaxLength(150).IsRequired();
            builder.Property(pf => pf.CdPais).HasMaxLength(5).IsRequired();
        }
    }
}
