using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0150EFDCConfiguration : IEntityTypeConfiguration<Reg0150EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0150EFDC> builder)
        {
            builder.HasKey(_0150 => _0150.Id);
            builder.Property(_0150 => _0150.Reg).HasMaxLength(4).HasDefaultValue("0150").IsRequired();
            builder.Property(_0150 => _0150.CodPart).HasMaxLength(60);
            builder.Property(_0150 => _0150.Nome).HasMaxLength(100).IsRequired();
            builder.Property(_0150 => _0150.CNPJ).HasMaxLength(14).IsRequired();
            builder.Property(_0150 => _0150.CPF).HasMaxLength(2).IsRequired();
            builder.Property(_0150 => _0150.IE).HasMaxLength(14);
            builder.Property(_0150 => _0150.MunicipioId).IsRequired();
            builder.Property(_0150 => _0150.Suframa).HasMaxLength(9);
            builder.Property(_0150 => _0150.End).HasMaxLength(255);
            builder.Property(_0150 => _0150.Num).HasMaxLength(255);
            builder.Property(_0150 => _0150.Compl).HasMaxLength(255);
            builder.Property(_0150 => _0150.Bairro).HasMaxLength(255);
            builder.Property(_0150 => _0150.DtIni).IsRequired();
            builder.HasOne(_0150 => _0150.PessoaJuridica);
            builder.HasOne(_0150 => _0150.User);
        }
    }
}
