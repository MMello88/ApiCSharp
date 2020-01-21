using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0000Configuration : IEntityTypeConfiguration<Reg0000>
    {
        public void Configure(EntityTypeBuilder<Reg0000> builder)
        {
            builder.HasKey(_0000 => _0000.Id);
            builder.Property(_0000 => _0000.REG).HasMaxLength(4).HasDefaultValue("0000").IsRequired();
            builder.Property(_0000 => _0000.TIPO_ESCRIT).HasMaxLength(1).IsRequired();
            builder.Property(_0000 => _0000.IND_SIT_ESP).HasMaxLength(1);
            builder.Property(_0000 => _0000.NUM_REC_ANTERIOR).HasMaxLength(41);
            builder.Property(_0000 => _0000.DT_INI).IsRequired();
            builder.Property(_0000 => _0000.DT_FIN).IsRequired();
            builder.Property(_0000 => _0000.NOME).HasMaxLength(100).IsRequired();
            builder.Property(_0000 => _0000.CNPJ).HasMaxLength(14).IsRequired();
            builder.Property(_0000 => _0000.SUFRAMA).HasMaxLength(9);
            builder.Property(_0000 => _0000.IND_NAT_PJ).HasMaxLength(2);
            builder.Property(_0000 => _0000.IND_ATIV).HasMaxLength(1).IsRequired();
        }
    }
}
