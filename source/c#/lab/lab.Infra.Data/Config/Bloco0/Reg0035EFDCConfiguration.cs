using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0035EFDCConfiguration : IEntityTypeConfiguration<Reg0035EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0035EFDC> builder)
        {
            builder.HasKey(_0035 => _0035.Id);
            builder.Property(_0035 => _0035.Reg).HasMaxLength(4).HasDefaultValue("0000").IsRequired();
            builder.Property(_0035 => _0035.CodSCP).HasMaxLength(14).IsRequired();
            builder.Property(_0035 => _0035.DescSCP).HasMaxLength(255).IsRequired();
            builder.Property(_0035 => _0035.InfoCompl).HasMaxLength(255).IsRequired();
            builder.HasOne(_0035 => _0035.Reg0000EFDC).WithMany(_0001 => _0001.Regs0035EFDC);
        }
    }
}
