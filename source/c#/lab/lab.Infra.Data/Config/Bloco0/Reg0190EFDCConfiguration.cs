using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0190EFDCConfiguration : IEntityTypeConfiguration<Reg0190EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0190EFDC> builder)
        {
            builder.HasKey(_0190 => _0190.Id);
            builder.Property(_0190 => _0190.Reg).HasMaxLength(4).HasDefaultValue("0190").IsRequired();
            builder.Property(_0190 => _0190.Unidade).HasMaxLength(6).IsRequired();
            builder.Property(_0190 => _0190.Descrição).HasMaxLength(255).IsRequired();
            builder.Property(_0190 => _0190.DtIni).IsRequired();
            builder.HasOne(_0190 => _0190.PessoaJuridica);
            builder.HasOne(_0190 => _0190.User);
        }
    }
}
