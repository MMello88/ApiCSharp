using lab.Domain.Entities.Bloco.bA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.BlocoA
{
    public class RegA001EFDCConfiguration : IEntityTypeConfiguration<RegA001EFDC>
    {
        public void Configure(EntityTypeBuilder<RegA001EFDC> builder)
        {
            builder.HasKey(_A001 => _A001.Id);
            builder.Property(_A001 => _A001.Reg).HasMaxLength(4).HasDefaultValue("A001").IsRequired();
            builder.Property(_A001 => _A001.IndicadorMovimento).HasMaxLength(1).IsRequired();
            builder.Property(_A001 => _A001.DtIni).IsRequired();
        }
    }
}
