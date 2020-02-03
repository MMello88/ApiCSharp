using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0600EFDCConfiguration : IEntityTypeConfiguration<Reg0600EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0600EFDC> builder)
        {
            builder.HasKey(_0600 => _0600.Id);
            builder.Property(_0600 => _0600.Reg).HasMaxLength(4).HasDefaultValue("0600").IsRequired();
            builder.Property(_0600 => _0600.DtAlteracao).IsRequired();
            builder.Property(_0600 => _0600.CodCCusto).HasMaxLength(255).IsRequired();
            builder.Property(_0600 => _0600.NomeCCusto).HasMaxLength(60).IsRequired();
        }
    }
}
