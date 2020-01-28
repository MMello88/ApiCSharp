using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref432Configuration : IEntityTypeConfiguration<Ref432>
    {
        public void Configure(EntityTypeBuilder<Ref432> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
			builder.HasData(
				new Ref432() { Id = 1, Codigo = "00", Descricao = "Entrada com recuperação de crédito", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 2, Codigo = "01", Descricao = "Entrada tributada com alíquota zero", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 3, Codigo = "02", Descricao = "Entrada isenta", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 4, Codigo = "03", Descricao = "Entrada não-tributada", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 5, Codigo = "04", Descricao = "Entrada imune", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 6, Codigo = "05", Descricao = "Entrada com suspensão", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 7, Codigo = "49", Descricao = "Outras entradas", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 8, Codigo = "50", Descricao = "Saída tributada", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 9, Codigo = "51", Descricao = "Saída tributada com alíquota zero", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 10, Codigo = "52", Descricao = "Saída isenta", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 11, Codigo = "53", Descricao = "Saída não-tributada", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 12, Codigo = "54", Descricao = "Saída imune", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 13, Codigo = "55", Descricao = "Saída com suspensão", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref432() { Id = 14, Codigo = "99", Descricao = "Outras saídas", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null }
			);
		}
    }
}
