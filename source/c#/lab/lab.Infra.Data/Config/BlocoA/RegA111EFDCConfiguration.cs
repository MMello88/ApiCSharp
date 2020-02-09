using lab.Domain.Entities.Bloco.bA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.BlocoA
{
    public class RegA111EFDCConfiguration : IEntityTypeConfiguration<RegA111EFDC>
    {
        public void Configure(EntityTypeBuilder<RegA111EFDC> builder)
        {
            builder.HasKey(_A111 => _A111.Id);
            builder.Property(_A111 => _A111.Reg).HasMaxLength(4).HasDefaultValue("A111").IsRequired();
            builder.Property(_A111 => _A111.IndicadorOrigemProcesso).IsRequired();
            builder.Property(_A111 => _A111.NumProcesso).HasMaxLength(15).IsRequired();
			builder.HasOne(_A111 => _A111.RegA100EFDC).WithMany(_A100 => _A100.RegsA111EFDC);
        }
    }
}
