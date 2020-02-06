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
            builder.Property(_0200 => _0200.CodItem).HasMaxLength(60).IsRequired();
            builder.Property(_0200 => _0200.DescricaoItem).HasMaxLength(255).IsRequired();
            builder.Property(_0200 => _0200.CodBarra).HasMaxLength(255);
            builder.Property(_0200 => _0200.CodAntItem).HasMaxLength(60);
            builder.HasOne(_0200 => _0200.Reg0190EFDC);
            builder.Property(_0200 => _0200.TipoItem).IsRequired();
            builder.Property(_0200 => _0200.CodNcm).HasMaxLength(8);
            builder.Property(_0200 => _0200.ExIpi).HasMaxLength(3);
            builder.Property(_0200 => _0200.CodGen).HasMaxLength(2);
            builder.Property(_0200 => _0200.CodLst).HasMaxLength(5);
            builder.Property(_0200 => _0200.AliqIcms).HasColumnType("decimal(6, 2)");
            builder.Property(_0200 => _0200.DtIni).IsRequired();
            builder.HasOne(_0200 => _0200.PessoaJuridica);
            builder.HasOne(_0200 => _0200.User);
        }
    }
}
