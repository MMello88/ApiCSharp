using lab.Domain.Entities.Bloco.bA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.BlocoA
{
    public class RegA010EFDCConfiguration : IEntityTypeConfiguration<RegA010EFDC>
    {
        public void Configure(EntityTypeBuilder<RegA010EFDC> builder)
        {
            builder.HasKey(_A010 => _A010.Id);
            builder.Property(_A010 => _A010.Reg).HasMaxLength(4).HasDefaultValue("A010").IsRequired();
            builder.Property(_A010 => _A010.CNPJ).HasMaxLength(14).IsRequired();
            builder.Property(_A010 => _A010.DtIni).IsRequired();
        }
    }
}
