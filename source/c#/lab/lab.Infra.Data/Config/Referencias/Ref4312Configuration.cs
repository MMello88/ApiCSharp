using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref4312Configuration : IEntityTypeConfiguration<Ref4312>
    {
        public void Configure(EntityTypeBuilder<Ref4312> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
            builder.Property(r => r.Ncm).IsRequired();
			builder.HasData(
				new Ref4312() { Id = 1, Codigo = "101", Descricao = "Cigarros, de fumo (tabaco) ou dos seus sucedâneos", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "2402", NcmEx = "", ExIpi = "", AliqPis = 0.65f, AliqCofins = 3.0f },
				new Ref4312() { Id = 2, Codigo = "102", Descricao = "Cigarrilhas", DataInicial = DateTime.ParseExact("01082011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "24021000", NcmEx = "", ExIpi = "", AliqPis = 0.65f, AliqCofins = 3.0f },
				new Ref4312() { Id = 3, Codigo = "201", Descricao = "Motocicletas (incluídos os ciclomotores) e outros ciclos equipados com motor auxiliar, mesmo com carro lateral; carros laterais", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "8711", NcmEx = "", ExIpi = "", AliqPis = 0.65f, AliqCofins = 3.0f },
				new Ref4312() { Id = 4, Codigo = "301", Descricao = "Semeadores, plantadores e transplantadores", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = DateTime.ParseExact("13052014", "ddMMyyyy", CultureInfo.InvariantCulture), Ncm = "", NcmEx = "", ExIpi = "", AliqPis = 0.65f, AliqCofins = 3.0f },
				new Ref4312() { Id = 5, Codigo = "401", Descricao = "Álcool, inclusive para fins carburantes - Vendas por Produtor/Importador", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "", AliqPis = 8.57f, AliqCofins = 39.43f },
				new Ref4312() { Id = 6, Codigo = "402", Descricao = "Álcool, inclusive para fins carburantes - Vendas por Distribuidor", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "", AliqPis = 21.43f, AliqCofins = 98.57f },
				new Ref4312() { Id = 7, Codigo = "403", Descricao = "Gasolinas, Óleo Dieses e GLP", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "", AliqPis = null, AliqCofins = null },
				new Ref4312() { Id = 8, Codigo = "404", Descricao = "Veiculos", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "", AliqPis = null, AliqCofins = null },
				new Ref4312() { Id = 9, Codigo = "405", Descricao = "Autopeças", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "", AliqPis = null, AliqCofins = null },
				new Ref4312() { Id = 10, Codigo = "406", Descricao = "Pneus", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "", AliqPis = null, AliqCofins = null },
				new Ref4312() { Id = 11, Codigo = "407", Descricao = "Bebidas Frias", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "", AliqPis = null, AliqCofins = null },
				new Ref4312() { Id = 12, Codigo = "408", Descricao = "Embalagens para bebidas Frias", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "", AliqPis = null, AliqCofins = null },
				new Ref4312() { Id = 13, Codigo = "409", Descricao = "Artigos de Perfumaria", DataInicial = DateTime.ParseExact("01012009", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null, Ncm = "", NcmEx = "", ExIpi = "", AliqPis = null, AliqCofins = null },
				new Ref4312() { Id = 14, Codigo = "999", Descricao = "Revenda de produtos sujeitos à substituição tributária", DataInicial = DateTime.ParseExact("01082013", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = DateTime.ParseExact("31122013", "ddMMyyyy", CultureInfo.InvariantCulture), Ncm = "", NcmEx = "", ExIpi = "", AliqPis = 0f, AliqCofins = 0f }
			);
		}
    }
}
