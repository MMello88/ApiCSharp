﻿using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref4314Configurarion : IEntityTypeConfiguration<Ref4314>
    {
        public void Configure(EntityTypeBuilder<Ref4314> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
            builder.Property(r => r.Ncm).IsRequired();
        }
    }
}