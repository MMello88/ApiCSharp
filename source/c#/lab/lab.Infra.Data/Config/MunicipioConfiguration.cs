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
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Nome).HasMaxLength(150).IsRequired();
            builder.Property(m => m.CdMunicipio).HasMaxLength(7).IsRequired();
            builder.Property(m => m.Uf).HasMaxLength(2).IsRequired();
            builder.HasMany(m => m.PessoasJuridica).WithOne(pj => pj.Municipio);
            builder.HasMany(m => m.regs0000).WithOne(reg0000 => reg0000.Municipio);
        }
    }
}
