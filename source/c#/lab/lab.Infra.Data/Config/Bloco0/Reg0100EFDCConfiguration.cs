using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0100EFDCConfiguration : IEntityTypeConfiguration<Reg0100EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0100EFDC> builder)
        {
            builder.HasKey(_0100 => _0100.Id);
            builder.Property(_0100 => _0100.Reg).HasMaxLength(4).HasDefaultValue("0100").IsRequired();
            builder.Property(_0100 => _0100.Nome).HasMaxLength(100).IsRequired();
            builder.Property(_0100 => _0100.CPF).HasMaxLength(11).IsRequired();
            builder.Property(_0100 => _0100.CRC).HasMaxLength(15).IsRequired();
            builder.Property(_0100 => _0100.CNPJ).HasMaxLength(14);
            builder.Property(_0100 => _0100.CEP).HasMaxLength(8);
            builder.Property(_0100 => _0100.End).HasMaxLength(60);
            builder.Property(_0100 => _0100.Num).HasMaxLength(5);
            builder.Property(_0100 => _0100.Compl).HasMaxLength(60);
            builder.Property(_0100 => _0100.Bairro).HasMaxLength(60);
            builder.Property(_0100 => _0100.Fone).HasMaxLength(11);
            builder.Property(_0100 => _0100.Fax).HasMaxLength(11);
            builder.Property(_0100 => _0100.Email).HasMaxLength(255);
            builder.HasOne(_0100 => _0100.PessoaJuridica);
            builder.HasOne(_0100 => _0100.User);
        }
    }
}
