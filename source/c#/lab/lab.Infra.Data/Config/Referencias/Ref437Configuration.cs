using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref437Configuration : IEntityTypeConfiguration<Ref437>
    {
        public void Configure(EntityTypeBuilder<Ref437> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
			builder.HasData(
				new Ref437() { Id = 1, Codigo = "01", Descricao = "Aquisição de bens para revenda", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 2, Codigo = "02", Descricao = "Aquisição de bens utilizados como insumo", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 3, Codigo = "03", Descricao = "Aquisição de serviços utilizados como insumo", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 4, Codigo = "04", Descricao = "Energia elétrica e térmica, inclusive sob a forma de vapor", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 5, Codigo = "05", Descricao = "Aluguéis de prédios", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 6, Codigo = "06", Descricao = "Aluguéis de máquinas e equipamentos", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 7, Codigo = "07", Descricao = "Armazenagem de mercadoria e frete na operação de venda", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 8, Codigo = "08", Descricao = "Contraprestações de arrendamento mercantil", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 9, Codigo = "09", Descricao = "Máquinas, equipamentos e outros bens incorporados ao ativo imobilizado (crédito sobre encargos de depreciação)", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 10, Codigo = "10", Descricao = "Máquinas, equipamentos e outros bens incorporados ao ativo imobilizado (crédito com base no valor de aquisição)", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 11, Codigo = "11", Descricao = "Amortização de edificações e benfeitorias em imóveis", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 12, Codigo = "12", Descricao = "Devolução de Vendas Sujeitas à Incidência Não-Cumulativa", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 13, Codigo = "13", Descricao = "Outras Operações com Direito a Crédito", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 14, Codigo = "14", Descricao = "Atividade de Transporte de Cargas - Subcontratação", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 15, Codigo = "15", Descricao = "Atividade Imobiliária - Custo Incorrido de Unidade Imobiliária", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 16, Codigo = "16", Descricao = "Atividade Imobiliária - Custo Orçado de unidade não concluída", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 17, Codigo = "17", Descricao = "Atividade de Prestação de Serviços de Limpeza, Conservação e Manutenção - vale-transporte, vale-refeição ou vale-alimentação, fardamento ou uniforme", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref437() { Id = 18, Codigo = "18", Descricao = "Estoque de abertura de bens", DataInicial = DateTime.ParseExact("01012006", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null }
			);
		}
    }
}
