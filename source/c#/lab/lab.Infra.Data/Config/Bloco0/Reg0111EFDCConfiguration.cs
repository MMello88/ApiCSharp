using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0111EFDCConfiguration : IEntityTypeConfiguration<Reg0111EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0111EFDC> builder)
        {
            builder.HasKey(_0111 => _0111.Id);
            builder.Property(_0111 => _0111.Reg).HasMaxLength(4).HasDefaultValue("0111").IsRequired();
            builder.Property(_0111 => _0111.RecBruNCumTribMI).HasMaxLength(2).IsRequired();
            builder.Property(_0111 => _0111.RecBruNCumNaoTribMI).HasMaxLength(2).IsRequired();
            builder.Property(_0111 => _0111.RecBruNCumExp).HasMaxLength(2).IsRequired();
            builder.Property(_0111 => _0111.RecBruNCum).HasMaxLength(2).IsRequired();
            builder.Property(_0111 => _0111.RecBruNCumTotal).HasMaxLength(2).IsRequired();
        }
    }
}
