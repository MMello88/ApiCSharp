using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0450EFDCConfiguration : IEntityTypeConfiguration<Reg0450EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0450EFDC> builder)
        {
            builder.HasKey(_0450 => _0450.Id);
            builder.Property(_0450 => _0450.Reg).HasMaxLength(4).HasDefaultValue("0450").IsRequired();
            builder.Property(_0450 => _0450.CodInf).HasMaxLength(6).IsRequired();
            builder.Property(_0450 => _0450.Txt).HasMaxLength(255).IsRequired();
            builder.Property(_0450 => _0450.DtIni).IsRequired();
            builder.HasOne(_0450 => _0450.PessoaJuridica);
            builder.HasOne(_0450 => _0450.User);
        }
    }
}
