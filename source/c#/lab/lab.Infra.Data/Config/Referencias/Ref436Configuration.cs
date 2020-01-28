using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref436Configuration : IEntityTypeConfiguration<Ref436>
    {
        public void Configure(EntityTypeBuilder<Ref436> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
			builder.HasData(
				new Ref436() { Id = 1, Codigo = "101", Descricao = "Crédito vinculado à receita tributada no mercado interno - Alíquota Básica", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 2, Codigo = "102", Descricao = "Crédito vinculado à receita tributada no mercado interno - Alíquotas Diferenciadas", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 3, Codigo = "103", Descricao = "Crédito vinculado à receita tributada no mercado interno - Alíquota por Unidade de Produto", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 4, Codigo = "104", Descricao = "Crédito vinculado à receita tributada no mercado interno - Estoque de Abertura", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 5, Codigo = "105", Descricao = "Crédito vinculado à receita tributada no mercado interno - Aquisição Embalagens para revenda", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 6, Codigo = "106", Descricao = "Crédito vinculado à receita tributada no mercado interno - Presumido da Agroindústria", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 7, Codigo = "107", Descricao = "Crédito vinculado à receita tributada no mercado interno - Demais Créditos Presumidos", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 8, Codigo = "108", Descricao = "Crédito vinculado à receita tributada no mercado interno - Importação", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 9, Codigo = "109", Descricao = "Crédito vinculado à receita tributada no mercado interno - Atividade Imobiliária", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 10, Codigo = "199", Descricao = "Crédito vinculado à receita tributada no mercado interno - Outros", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 11, Codigo = "201", Descricao = "Crédito vinculado à receita não tributada no mercado interno - Alíquota Básica", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 12, Codigo = "202", Descricao = "Crédito vinculado à receita não tributada no mercado interno - Alíquotas Diferenciadas", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 13, Codigo = "203", Descricao = "Crédito vinculado à receita não tributada no mercado interno - Alíquota por Unidade de Produto", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 14, Codigo = "204", Descricao = "Crédito vinculado à receita não tributada no mercado interno - Estoque de Abertura", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 15, Codigo = "205", Descricao = "Crédito vinculado à receita não tributada no mercado interno - Aquisição Embalagens para revenda", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 16, Codigo = "206", Descricao = "Crédito vinculado à receita não tributada no mercado interno - Presumido da Agroindústria", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 17, Codigo = "207", Descricao = "Crédito vinculado à receita não tributada no mercado interno - Demais Créditos Presumidos", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 18, Codigo = "208", Descricao = "Crédito vinculado à receita não tributada no mercado interno - Importação", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 19, Codigo = "299", Descricao = "Crédito vinculado à receita não tributada no mercado interno - Outros", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 20, Codigo = "301", Descricao = "Crédito vinculado à receita de exportação - Alíquota Básica", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 21, Codigo = "302", Descricao = "Crédito vinculado à receita de exportação - Alíquotas Diferenciadas", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 22, Codigo = "303", Descricao = "Crédito vinculado à receita de exportação - Alíquota por Unidade de Produto", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 23, Codigo = "304", Descricao = "Crédito vinculado à receita de exportação - Estoque de Abertura", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 24, Codigo = "305", Descricao = "Crédito vinculado à receita de exportação - Aquisição Embalagens para revenda", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 25, Codigo = "306", Descricao = "Crédito vinculado à receita de exportação - Presumido da Agroindústria", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 26, Codigo = "307", Descricao = "Crédito vinculado à receita de exportação - Demais Créditos Presumidos", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 27, Codigo = "308", Descricao = "Crédito vinculado à receita de exportação - Importação", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref436() { Id = 28, Codigo = "399", Descricao = "Crédito vinculado à receita de exportação - Outros", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null }
			);
		}
    }
}
