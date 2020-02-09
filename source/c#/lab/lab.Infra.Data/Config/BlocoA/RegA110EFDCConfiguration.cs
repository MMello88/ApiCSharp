using lab.Domain.Entities.Bloco.bA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.BlocoA
{
    public class RegA110EFDCConfiguration : IEntityTypeConfiguration<RegA110EFDC>
    {
        public void Configure(EntityTypeBuilder<RegA110EFDC> builder)
        {
            builder.HasKey(_A110 => _A110.Id);
            builder.Property(_A110 => _A110.Reg).HasMaxLength(4).HasDefaultValue("A110").IsRequired();
            builder.Property(_A110 => _A110.Reg0450EFDC).IsRequired();
            builder.Property(_A110 => _A110.TxtComplementar).HasMaxLength(255);
			builder.HasOne(_A110 => _A110.RegA100EFDC).WithMany(_A100 => _A100.RegsA110EFDC);
        }
    }
}
