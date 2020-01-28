using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref4315Configuration : IEntityTypeConfiguration<Ref4315>
    {
        public void Configure(EntityTypeBuilder<Ref4315> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
            builder.Property(r => r.Ncm).IsRequired();
            builder.HasData(
                new Ref4315() { Id = 1, Codigo = "101", Descricao = "Venda de querosene de aviação por pessoa jurídica não enquadrada na condição de importadora ou produtora", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
                new Ref4315() { Id = 2, Codigo = "102", Descricao = "Venda de querosene de aviação por produtora ou importadora a distribuidora, quando o produto for destinado ao consumo por aeronave em tráfego internacional", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
                new Ref4315() { Id = 3, Codigo = "201", Descricao = "Vendas de biodiesel por pessoas não enquadradas como produtor ou importador", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
                new Ref4315() { Id = 4, Codigo = "301", Descricao = "Vendas de materiais e equipamentos, bem assim da prestação de serviços decorrentes dessas operações, efetuadas diretamente a Itaipu Binacional", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
                new Ref4315() { Id = 5, Codigo = "401", Descricao = "Exportação de mercadorias para o exterior", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
                new Ref4315() { Id = 6, Codigo = "402", Descricao = "Serviços prestados a pessoas físicas ou jurídicas residentes ou domiciliadas no exterior, cujo pagamento represente ingresso de divisas", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
                new Ref4315() { Id = 7, Codigo = "403", Descricao = "Vendas, com o fim específico de exportação, a empresa comercial exportadora constituída nos termos do Decreto-Lei nº 1.248, de 29 de novembro de 1972, ou simplesmente registrada na Secretaria de Comércio Exterior (Secex) do Ministério do Desenvolvimento, Indústria e Comércio Exterior", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
                new Ref4315() { Id = 8, Codigo = "901", Descricao = "Regime Cumulativo - Demais receitas não classificadas como faturamento,não enquadradas como receita bruta nos termos do art. 3º da Lei nº 9.718, de 1998", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" },
                new Ref4315() { Id = 9, Codigo = "999", Descricao = "Outras receitas sem incidência", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "" }
            );
        }
    }
}
