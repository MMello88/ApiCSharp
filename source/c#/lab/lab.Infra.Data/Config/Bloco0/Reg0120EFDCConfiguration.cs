using lab.Domain.Entities.Registro;
using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0120EFDCConfiguration : IEntityTypeConfiguration<Reg0120EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0120EFDC> builder)
        {
            builder.HasKey(_0120 => _0120.Id);
            builder.Property(_0120 => _0120.Reg).HasMaxLength(4).HasDefaultValue("0120").IsRequired();
            builder.Property(_0120 => _0120.MesRefer).IsRequired();
            builder.Property(_0120 => _0120.InfoCompl).IsRequired();
            builder.Property(_0120 => _0120.DtIni).IsRequired();
            builder.HasOne(_0120 => _0120.PessoaJuridica);
            builder.HasOne(_0120 => _0120.User);
        }
    }
}
