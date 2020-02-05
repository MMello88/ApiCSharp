using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0400EFDCConfiguration : IEntityTypeConfiguration<Reg0400EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0400EFDC> builder)
        {
            builder.HasKey(_0400 => _0400.Id);
            builder.Property(_0400 => _0400.Reg).HasMaxLength(4).HasDefaultValue("0400").IsRequired();
            builder.Property(_0400 => _0400.CodNat).HasMaxLength(60);
            builder.Property(_0400 => _0400.DescricaoNat).HasMaxLength(100).IsRequired();
            builder.Property(_0400 => _0400.DtIni).IsRequired();
            builder.HasOne(_0400 => _0400.PessoaJuridica);
            builder.HasOne(_0400 => _0400.User);
        }
    }
}
