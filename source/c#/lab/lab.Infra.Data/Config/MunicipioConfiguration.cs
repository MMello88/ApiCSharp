using lab.Domain.Entities.Cadastro.Auxiliar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace lab.Infra.Data.Config
{
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.HasKey(pf => pf.Id);
            builder.Property(pf => pf.Nome).HasMaxLength(150).IsRequired();
            builder.Property(pf => pf.CdMunicipio).HasMaxLength(7).IsRequired();
            builder.Property(pf => pf.Uf).HasMaxLength(2).IsRequired();
        }
    }
}
