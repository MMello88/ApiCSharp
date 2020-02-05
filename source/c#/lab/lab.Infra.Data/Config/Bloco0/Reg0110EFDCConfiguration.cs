using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0110EFDCConfiguration : IEntityTypeConfiguration<Reg0110EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0110EFDC> builder)
        {
            builder.HasKey(_0110 => _0110.Id);
            builder.Property(_0110 => _0110.Reg).HasMaxLength(4).HasDefaultValue("0110").IsRequired();
            builder.Property(_0110 => _0110.CodIncTrib).HasMaxLength(1).IsRequired();
            builder.Property(_0110 => _0110.IndAproCred).HasMaxLength(1);
            builder.Property(_0110 => _0110.CodTipoCont).HasMaxLength(1);
            builder.Property(_0110 => _0110.IndRegCum).HasMaxLength(1);
            builder.Property(_0110 => _0110.DtIni).IsRequired();
            builder.HasOne(_0110 => _0110.Reg0111EFDC);
            builder.HasOne(_0110 => _0110.PessoaJuridica);
            builder.HasOne(_0110 => _0110.User);
        }
    }
}
