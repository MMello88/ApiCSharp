using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Globalization;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref4318Configuration : IEntityTypeConfiguration<Ref4318>
    {
        public void Configure(EntityTypeBuilder<Ref4318> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(30).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(r => r.DataInicial).IsRequired();
            builder.HasData(
                new Ref4318() { Id = 1, Codigo = "01", Descricao = "Vendas canceladas de receitas tributadas em períodos anteriores", Obrigatorio = "N", DataInicial = DateTime.ParseExact("01012002", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
                new Ref4318() { Id = 2, Codigo = "02", Descricao = "Devoluções de vendas tributadas em períodos anteriores", Obrigatorio = "N", DataInicial = DateTime.ParseExact("01012002", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
                new Ref4318() { Id = 3, Codigo = "21", Descricao = "ICMS a recolher sobre Operações próprias (PJs com decisão judicial transitada em julgado)", Obrigatorio = "N", DataInicial = DateTime.ParseExact("01012002", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = DateTime.ParseExact("31032019", "ddMMyyyy", CultureInfo.InvariantCulture) },
                new Ref4318() { Id = 4, Codigo = "21", Descricao = "ICMS a recolher sobre Operações próprias (PJs com decisão judicial transitada em julgado)", Obrigatorio = "S", DataInicial = DateTime.ParseExact("01042019", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
                new Ref4318() { Id = 5, Codigo = "41", Descricao = "Outros valores a excluir, vinculados à decisão judicial com trânsito em julgado", Obrigatorio = "N", DataInicial = DateTime.ParseExact("01012002", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null },
                new Ref4318() { Id = 6, Codigo = "42", Descricao = "Outros valores a excluir, não vinculados à decisão judicial", Obrigatorio = "N", DataInicial = DateTime.ParseExact("01012002", "ddMMyyyy", CultureInfo.InvariantCulture), DataFinal = null }
            );
        }
    }
}
