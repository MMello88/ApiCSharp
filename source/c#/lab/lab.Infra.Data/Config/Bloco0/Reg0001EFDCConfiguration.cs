using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    public class Reg0001EFDCConfiguration : IEntityTypeConfiguration<Reg0001EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0001EFDC> builder)
        {
            builder.HasKey(_0000 => _0000.Id);
            builder.Property(_0000 => _0000.Reg).HasMaxLength(4).HasDefaultValue("0000").IsRequired();
            builder.Property(_0000 => _0000.IndicadorMovimento).HasMaxLength(1).IsRequired();
        }
    }
}
