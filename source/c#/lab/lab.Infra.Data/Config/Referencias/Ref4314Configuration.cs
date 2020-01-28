using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref4314Configuration : IEntityTypeConfiguration<Ref4314>
    {
        public void Configure(EntityTypeBuilder<Ref4314> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
            builder.Property(r => r.Ncm).IsRequired();
			builder.HasData(
				new Ref4314() { Id = 1, Codigo = "101", Descricao = "Fornecimento de mercadorias ou serviços para uso ou consumo de bordo em embarcações e aeronaves em tráfego internacional, quando o pagamento for efetuado em moeda conversível (exceto querosene de aviação)", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 2, Codigo = "102", Descricao = "Transporte internacional de cargas ou passageiros", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 3, Codigo = "103", Descricao = "Receitas auferidas pelos estaleiros navais brasileiros nas atividades de construção, conservação, modernização, conversão e reparo de embarcações pré-registradas ou registradas no Registro Especial Brasileiro (REB), instituído pela Lei nº 9.432, de 8 de janeiro de 1997", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 4, Codigo = "104", Descricao = "Frete de mercadorias transportadas entre o País e o exterior pelas embarcações registradas no REB, de que trata o art. 11 da Lei nº 9.432, de 1997", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 5, Codigo = "201", Descricao = "Receitas relativas às atividades próprias dos templos de qualquer culto;partidos políticos;instituições de educação e de assistência social conforme art. 12 da Lei nº 9.532;instituições conforme art. 15 da Lei nº 9.532 ou previstas no art. 105 e seu § 1º da Lei nº 5.764", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 6, Codigo = "301", Descricao = "Venda de energia elétrica pela Itaipu Binacional", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 7, Codigo = "901", Descricao = "Recursos recebidos a título de repasse, oriundos do Orçamento Geral da União, dos Estados, do Distrito Federal e dos Municípios, pelas empresas públicas e sociedades de economia mista", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 8, Codigo = "902", Descricao = "Receita da instituição privada de ensino superior, com fins lucrativos ou sem fins lucrativos não beneficente, que aderir ao Programa Universidade para Todos (Prouni), no período de vigência do termo de adesão, decorrentes da realização de atividades de ensino superior, proveniente de cursos de graduação ou cursos seqüenciais de formação específica", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 9, Codigo = "999", Descricao = "isençãoCódigo genérico  Operações com Isenção", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 10, Codigo = "903", Descricao = "Rec. bruta de venda a varejo dos componentes e equipamentos de rede,terminais e transceptores definidos em regulamento que sejam dedicados aos serviços de telecom prestados por meio das subfaixas de radiofrequência de 451 a 458 MHz e de 461 a 468 MHz,assim como por meio de estações terrenas satelitais de pequeno porte que contribuam para o PNBL", DataInicial = DateTime.ParseExact("18092012", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = DateTime.ParseExact("31122018", "ddMMyyyy", CultureInfo.InvariantCulture), Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 11, Codigo = "404", Descricao = "Importações de bens, mercadorias ou serviços para uso ou consumo exclusivo em atividades próprias e diretamente vinculadas à organização ou realização dos Eventos Olímpicos de 2016, realizadas pelas entidades referidas no § 2º do art. 4º, da Lei nº 12.780/2013", DataInicial = DateTime.ParseExact("01012013", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = DateTime.ParseExact("31122017", "ddMMyyyy", CultureInfo.InvariantCulture), Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 12, Codigo = "405", Descricao = "Rendimentos, remessas e operações de câmbio e seguros, decorrentes das atividades próprias e diretamente vinculadas à organização ou realização dos eventos olímpicos de 2016, envolvendo o CIO e as empresas a ele vinculadas", DataInicial = DateTime.ParseExact("01012013", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = DateTime.ParseExact("31122017", "ddMMyyyy", CultureInfo.InvariantCulture), Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 13, Codigo = "406", Descricao = "Receitas e rendimentos auferidos pelas empresas vinculadas ao CIO, e domiciliadas no Brasil, em relação aos fatos geradores decorrentes das atividades próprias e diretamente vinculadas à organização ou realização dos Eventos Olímpicos de 2016", DataInicial = DateTime.ParseExact("01012013", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = DateTime.ParseExact("31122017", "ddMMyyyy", CultureInfo.InvariantCulture), Ncm = "", NcmEx = "", ExIpi = "" },
				new Ref4314() { Id = 14, Codigo = "407", Descricao = "Receitas, lucros e rendimentos auferidos pelo RIO 2016, em relação aos fatos geradores decorrentes das atividades próprias e diretamente vinculadas à organização ou realização do evento", DataInicial = DateTime.ParseExact("01012013", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = DateTime.ParseExact("31122017", "ddMMyyyy", CultureInfo.InvariantCulture), Ncm = "", NcmEx = "", ExIpi = "" }
			);
		}
    }
}
