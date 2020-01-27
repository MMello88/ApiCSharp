using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref411Configuration : IEntityTypeConfiguration<Ref411>
    {
        public void Configure(EntityTypeBuilder<Ref411> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.Modelo).HasMaxLength(20);
            builder.Property(r => r.DataInicial).IsRequired();
        }
    }
}