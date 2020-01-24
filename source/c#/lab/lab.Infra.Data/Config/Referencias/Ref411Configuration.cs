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
            builder.HasKey(ref => ref.Id);
            builder.Property(ref => ref.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(ref => ref.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(ref => ref.Modelo).HasMaxLength(20));
            builder.Property(ref => ref.DataInicial).IsRequired();
        }
    }
}
