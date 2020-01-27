using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref311Configuration : IEntityTypeConfiguration<Ref311>
    {
        public void Configure(EntityTypeBuilder<Ref311> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Codigo).HasMaxLength(5).IsRequired();
            builder.Property(r => r.Versao).HasMaxLength(5).IsRequired();
            builder.Property(r => r.Leiaout).HasMaxLength(100).IsRequired();
            builder.Property(r => r.Periodo).IsRequired();
            builder.HasMany(r => r.Regs0000EFD).WithOne(reg0000 => reg0000.Ref311);

            builder.HasData(
                new Ref311() { Id = 1, Codigo = "001", Versao = "1.00", Leiaout = "ADE Cofis nº 31/2010", Periodo = Convert.ToDateTime("01/04/2011") },
                new Ref311() { Id = 2, Codigo = "002", Versao = "1.01", Leiaout = "ADE Cofis nº 34/2010, atualizado pelo ADE Cofis nº 37/2010", Periodo = Convert.ToDateTime("01/04/2011") },
                new Ref311() { Id = 3, Codigo = "002", Versao = "2.00", Leiaout = "ADE Cofis nº 20/2012", Periodo = Convert.ToDateTime("01/04/2011") },
                new Ref311() { Id = 4, Codigo = "003", Versao = "2.01A", Leiaout = "ADE Cofis nº 20/2012", Periodo = Convert.ToDateTime("01/07/2012") },
                new Ref311() { Id = 5, Codigo = "004", Versao = "3.0.0", Leiaout = "ADE Cofis nº 20/2012", Periodo = Convert.ToDateTime("01/06/2018") },
                new Ref311() { Id = 6, Codigo = "005", Versao = "3.1.0", Leiaout = "ADE Cofis nº 82/2018", Periodo = Convert.ToDateTime("01/01/2019") },
                new Ref311() { Id = 7, Codigo = "006", Versao = "3.2.0", Leiaout = "ADE Cofis nº 82/2018", Periodo = Convert.ToDateTime("01/01/2020") }
                );
        }
    }
}
