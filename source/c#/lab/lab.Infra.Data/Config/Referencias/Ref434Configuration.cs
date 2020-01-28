using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref434Configuration : IEntityTypeConfiguration<Ref434>
    {
        public void Configure(EntityTypeBuilder<Ref434> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
			builder.HasData(
				new Ref434() { Id = 1, Codigo = "01", Descricao = "Operação Tributável com Alíquota Básica", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 2, Codigo = "02", Descricao = "Operação Tributável com Alíquota Diferenciada", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 3, Codigo = "03", Descricao = "Operação Tributável com Alíquota por Unidade de Medida de Produto", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 4, Codigo = "04", Descricao = "Operação Tributável Monofásica - Revenda a Alíquota Zero", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 5, Codigo = "05", Descricao = "Operação Tributável por Substituição Tributária", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 6, Codigo = "06", Descricao = "Operação Tributável a Alíquota Zero", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 7, Codigo = "07", Descricao = "Operação Isenta da Contribuição", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 8, Codigo = "08", Descricao = "Operação sem Incidência da Contribuição", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 9, Codigo = "09", Descricao = "Operação com Suspensão da Contribuição", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 10, Codigo = "49", Descricao = "Outras Operações de Saída", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 11, Codigo = "50", Descricao = "Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 12, Codigo = "51", Descricao = "Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 13, Codigo = "52", Descricao = "Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 14, Codigo = "53", Descricao = "Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 15, Codigo = "54", Descricao = "Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 16, Codigo = "55", Descricao = "Operação com Direito a Crédito - Vinculada a Receitas Não Tributadas no Mercado Interno e de Exportação", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 17, Codigo = "56", Descricao = "Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno e de Exportação", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 18, Codigo = "60", Descricao = "Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 19, Codigo = "61", Descricao = "Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 20, Codigo = "62", Descricao = "Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 21, Codigo = "63", Descricao = "Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 22, Codigo = "64", Descricao = "Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 23, Codigo = "65", Descricao = "Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 24, Codigo = "66", Descricao = "Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno e de Exportação", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 25, Codigo = "67", Descricao = "Crédito Presumido - Outras Operações", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 26, Codigo = "70", Descricao = "Operação de Aquisição sem Direito a Crédito", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 27, Codigo = "71", Descricao = "Operação de Aquisição com Isenção", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 28, Codigo = "72", Descricao = "Operação de Aquisição com Suspensão", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 29, Codigo = "73", Descricao = "Operação de Aquisição a Alíquota Zero", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 30, Codigo = "74", Descricao = "Operação de Aquisição sem Incidência da Contribuição", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 31, Codigo = "75", Descricao = "Operação de Aquisição por Substituição Tributária", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 32, Codigo = "98", Descricao = "Outras Operações de Entrada", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref434() { Id = 33, Codigo = "99", Descricao = "Outras Operações", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null }
			);
		}
    }
}
