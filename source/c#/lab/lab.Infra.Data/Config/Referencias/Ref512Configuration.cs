using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref512Configuration : IEntityTypeConfiguration<Ref512>
    {
        public void Configure(EntityTypeBuilder<Ref512> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
            builder.HasData(
                new Ref512() { Id = 1, Codigo = "00000001", Descricao = "Detalhamento por documento fiscal", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
                new Ref512() { Id = 2, Codigo = "00000002", Descricao = "Detalhamento por item/produto/serviço", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
                new Ref512() { Id = 3, Codigo = "00000003", Descricao = "Detalhamento por NCM", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
                new Ref512() { Id = 4, Codigo = "00000004", Descricao = "Detalhamento por Cliente", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
                new Ref512() { Id = 5, Codigo = "00000005", Descricao = "Detalhamento por outros critérios", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null }
            );
        }
    }
}
