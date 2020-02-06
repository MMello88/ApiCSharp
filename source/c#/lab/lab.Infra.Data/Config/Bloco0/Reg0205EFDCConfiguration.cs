using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0205EFDCConfiguration : IEntityTypeConfiguration<Reg0205EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0205EFDC> builder)
        {
            builder.HasKey(_0205 => _0205.Id);
            builder.Property(_0205 => _0205.Reg).HasMaxLength(4).HasDefaultValue("0205").IsRequired();
            builder.Property(_0205 => _0205.DescricaoAntItem).HasMaxLength(255).IsRequired();
            builder.Property(_0205 => _0205.CodAntItem).HasMaxLength(60);
            builder.Property(_0205 => _0205.DtIni).IsRequired();
            builder.Property(_0205 => _0205.DtFin).IsRequired();
        }
    }
}
