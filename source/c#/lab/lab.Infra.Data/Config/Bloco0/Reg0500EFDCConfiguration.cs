using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0500EFDCConfiguration : IEntityTypeConfiguration<Reg0500EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0500EFDC> builder)
        {
            builder.HasKey(_0500 => _0500.Id);
            builder.Property(_0500 => _0500.Reg).HasMaxLength(4).HasDefaultValue("0500").IsRequired();
            builder.Property(_0500 => _0500.DtAlteracao).IsRequired();
            builder.Property(_0500 => _0500.CodNatCC).IsRequired();
            builder.Property(_0500 => _0500.IndCTA).HasMaxLength(1).IsRequired();
            builder.Property(_0500 => _0500.Nivel).HasMaxLength(5).IsRequired();
            builder.Property(_0500 => _0500.CodCTA).HasMaxLength(255).IsRequired();
            builder.Property(_0500 => _0500.NomeCTA).HasMaxLength(60).IsRequired();
            builder.Property(_0500 => _0500.CodCTARef).HasMaxLength(60);
            builder.Property(_0500 => _0500.CNPJEstab).HasMaxLength(14);
            builder.Property(_0500 => _0500.DtIni).IsRequired();
            builder.HasOne(_0500 => _0500.PessoaJuridica);
            builder.HasOne(_0500 => _0500.User);
        }
    }
}
