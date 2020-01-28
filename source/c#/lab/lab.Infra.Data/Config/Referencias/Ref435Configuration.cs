using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref435Configuration : IEntityTypeConfiguration<Ref435>
    {
        public void Configure(EntityTypeBuilder<Ref435> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
			builder.HasData(
				new Ref435() { Id = 1, Codigo = "01", Descricao = "Contribuição não-cumulativa apurada a alíquota básica", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 2, Codigo = "02", Descricao = "Contribuição não-cumulativa apurada a alíquotas diferenciadas", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 3, Codigo = "03", Descricao = "Contribuição não-cumulativa apurada a alíquota por unidade de medida de produto", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 4, Codigo = "04", Descricao = "Contribuição não-cumulativa apurada a alíquota básica - Atividade Imobiliária", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 5, Codigo = "31", Descricao = "Contribuição apurada por substituição tributária", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 6, Codigo = "32", Descricao = "Contribuição apurada por substituição tributária - Vendas à Zona Franca de Manaus", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 7, Codigo = "51", Descricao = "Contribuição cumulativa apurada a alíquota básica", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 8, Codigo = "52", Descricao = "Contribuição cumulativa apurada a alíquotas diferenciadas", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 9, Codigo = "53", Descricao = "Contribuição cumulativa apurada a alíquota por unidade de medida de produto", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 10, Codigo = "54", Descricao = "Contribuição cumulativa apurada a alíquota básica - Atividade Imobiliária", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 11, Codigo = "70", Descricao = "Contribuição apurada da Atividade Imobiliária - RET", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 12, Codigo = "71", Descricao = "Contribuição apurada de SCP - Incidência Não Cumulativa", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 13, Codigo = "72", Descricao = "Contribuição apurada de SCP - Incidência Cumulativa", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref435() { Id = 14, Codigo = "99", Descricao = "Contribuição para o PIS/Pasep - Folha de Salários", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null }
			);
		}
    }
}
