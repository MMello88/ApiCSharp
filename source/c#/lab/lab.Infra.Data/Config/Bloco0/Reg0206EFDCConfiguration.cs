using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0206EFDCConfiguration : IEntityTypeConfiguration<Reg0206EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0206EFDC> builder)
        {
            builder.HasKey(_0206 => _0206.Id);
            builder.Property(_0206 => _0206.Reg).HasMaxLength(4).HasDefaultValue("0206").IsRequired();
            builder.Property(_0206 => _0206.CodComb).HasMaxLength(255).IsRequired();
        }
    }
}
