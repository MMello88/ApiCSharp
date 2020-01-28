using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

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
            builder.HasData(
                new Ref411() { Id = 1, Codigo = "01", Descricao = "Nota Fiscal", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 2, Codigo = "1B", Descricao = "Nota Fiscal Avulsa", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 3, Codigo = "02", Descricao = "Nota Fiscal de Venda a Consumidor", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 4, Codigo = "2D", Descricao = "Cupom Fiscal emitido por ECF", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 5, Codigo = "2E", Descricao = "Bilhete de Passagem emitido por ECF", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 6, Codigo = "04", Descricao = "Nota Fiscal de Produtor", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 7, Codigo = "06", Descricao = "Nota Fiscal/Conta de Energia Elétrica", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 8, Codigo = "07", Descricao = "Nota Fiscal de Serviço de Transporte", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 9, Codigo = "08", Descricao = "Conhecimento de Transporte Rodoviário de Cargas", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 10, Codigo = "8B", Descricao = "Conhecimento de Transporte de Cargas Avulso", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 11, Codigo = "09", Descricao = "Conhecimento de Transporte Aquaviário de Cargas", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 12, Codigo = "10", Descricao = "Conhecimento Aéreo", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 13, Codigo = "11", Descricao = "Conhecimento de Transporte Ferroviário de Cargas", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 14, Codigo = "13", Descricao = "Bilhete de Passagem Rodoviário", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 15, Codigo = "14", Descricao = "Bilhete de Passagem Aquaviário", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 16, Codigo = "15", Descricao = "Bilhete de Passagem e Nota de Bagagem", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 17, Codigo = "17", Descricao = "Despacho de Transporte", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 18, Codigo = "16", Descricao = "Bilhete de Passagem Ferroviário", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 19, Codigo = "18", Descricao = "Resumo de Movimento Diário", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 20, Codigo = "20", Descricao = "Ordem de Coleta de Cargas", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 21, Codigo = "21", Descricao = "Nota Fiscal de Serviço de Comunicação", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 22, Codigo = "22", Descricao = "Nota Fiscal de Serviço de Telecomunicação", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 23, Codigo = "23", Descricao = "GNRE", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 24, Codigo = "24", Descricao = "Autorização de Carregamento e Transporte", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 25, Codigo = "25", Descricao = "Manifesto de Carga", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 26, Codigo = "26", Descricao = "Conhecimento de Transporte Multimodal de Cargas", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 27, Codigo = "27", Descricao = "Nota Fiscal de Transporte Ferroviário de Cargas", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 28, Codigo = "28", Descricao = "Nota Fiscal/Conta de Fornecimento de Gás Canalizado", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 29, Codigo = "29", Descricao = "Nota Fiscal/Conta de Fornecimento de Água Canalizada", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 30, Codigo = "30", Descricao = "Bilhete/Recibo do Passageiro", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 31, Codigo = "55", Descricao = "Nota Fiscal Eletrônica", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 32, Codigo = "57", Descricao = "Conhecimento de Transporte Eletrônico - CT-e", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 33, Codigo = "59", Descricao = "Cupom Fiscal Eletrônico  CF-e", DataInicial = DateTime.ParseExact("01062011", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 34, Codigo = "60", Descricao = "Cupom Fiscal Eletrônico CF-e-ECF", DataInicial = DateTime.ParseExact("01012013", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 35, Codigo = "65", Descricao = "Nota Fiscal Eletrônica ao Consumidor Final  NFC-e", DataInicial = DateTime.ParseExact("01102012", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 36, Codigo = "67", Descricao = "Conhecimento de Transporte Eletrônico para Outros Serviços - CT-e OS", DataInicial = DateTime.ParseExact("01042017", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 37, Codigo = "63", Descricao = "Bilhete de Passagem Eletrônico - BP-e", DataInicial = DateTime.ParseExact("01012018", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null },
                new Ref411() { Id = 38, Codigo = "66", Descricao = "Nota Fiscal de Energia Elétrica Eletrônica - NF3e", DataInicial = DateTime.ParseExact("01012020", "ddMMyyyy", CultureInfo.InvariantCulture) , DataFinal = null }
            );
        }
    }
}
