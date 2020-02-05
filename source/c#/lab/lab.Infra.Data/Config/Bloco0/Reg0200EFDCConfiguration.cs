using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0200EFDCConfiguration : IEntityTypeConfiguration<Reg0200EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0200EFDC> builder)
        {
            builder.HasKey(_0200 => _0200.Id);
            builder.Property(_0200 => _0200.Reg).HasMaxLength(4).HasDefaultValue("0200").IsRequired();
            builder.Property(_0200 => _0200.CodItem).HasMaxLength(60);
            builder.Property(_0200 => _0200.DescricaoItem).HasMaxLength(100).IsRequired();
            builder.Property(_0200 => _0200.CodBarra).HasMaxLength(14).IsRequired();
            builder.Property(_0200 => _0200.CodAntItem).HasMaxLength(2).IsRequired();
            builder.Property(_0200 => _0200.UnidInv).HasMaxLength(14);
            builder.Property(_0200 => _0200.TipoItem).IsRequired();
            builder.Property(_0200 => _0200.CodNcm).HasMaxLength(255);
            builder.Property(_0200 => _0200.ExIpi).HasMaxLength(9);
            builder.Property(_0200 => _0200.CodGen).HasMaxLength(9);
            builder.Property(_0200 => _0200.CodLst).HasMaxLength(9);
            builder.Property(_0200 => _0200.AliqIcms).HasMaxLength(9);
            builder.Property(_0200 => _0200.DtIni).IsRequired();
            builder.HasOne(_0200 => _0200.PessoaJuridica);
            builder.HasOne(_0200 => _0200.User);
        }
    }
}
