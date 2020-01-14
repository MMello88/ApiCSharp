using lab.Domain.Entities.Enums;
using lab.Domain.Entities.Registro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab.Infra.Data.Config
{
    public class PessoaFisicaConfiguration : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            builder.HasKey(pf => pf.Id);
            builder.Property(pf => pf.Nome).HasMaxLength(250).IsRequired();
            builder.Property(pf => pf.Sobrenome).HasMaxLength(300).IsRequired();
            builder.Property(pf => pf.DataNascimento).IsRequired();
            builder.Property(pf => pf.UrlFoto).HasMaxLength(150);
            builder.Property(pf => pf.Ativo).HasDefaultValue(AtivoEnum.Ativo);
            builder.Property(pf => pf.Criacao).HasDefaultValue(DateTime.Now);
        }
    }
}
