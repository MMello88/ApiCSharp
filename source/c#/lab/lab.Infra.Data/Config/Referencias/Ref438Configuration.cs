using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref438Configuration : IEntityTypeConfiguration<Ref438>
    {
        public void Configure(EntityTypeBuilder<Ref438> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
			builder.HasData(
				new Ref438() { Id = 1, Codigo = "01", Descricao = "Ajuste Oriundo de Ação Judicial", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref438() { Id = 2, Codigo = "02", Descricao = "Ajuste Oriundo de Processo Administrativo", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref438() { Id = 3, Codigo = "03", Descricao = "Ajuste Oriundo da Legislação Tributária", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref438() { Id = 4, Codigo = "04", Descricao = "Ajuste Oriundo Especificamente do RTT", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref438() { Id = 5, Codigo = "05", Descricao = "Ajuste Oriundo de Outras Situações", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref438() { Id = 6, Codigo = "06", Descricao = "Estorno", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref438() { Id = 7, Codigo = "07", Descricao = "Ajuste Oriundo da Legislação Tributária  Adoção do Regime de Caixa  CPRB (Lei nº 12.546/2011, art. 9º, § 12)", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref438() { Id = 8, Codigo = "08", Descricao = "Ajuste Oriundo da Legislação Tributária  Diferimento de Valores a Recolher no Período  CPRB (Lei nº 12.546/2011, art. 9º, § 12)", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
				new Ref438() { Id = 9, Codigo = "09", Descricao = "Ajuste Oriundo da Legislação Tributária  Adição de Valores Diferidos em Período(s) Anterior(es)  CPRB (Lei nº 12.546/2011, art. 9º, § 12)", DataInicial = DateTime.ParseExact("01012011", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null }
			);
		}
    }
}
