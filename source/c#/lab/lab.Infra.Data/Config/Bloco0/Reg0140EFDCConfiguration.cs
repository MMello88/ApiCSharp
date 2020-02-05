using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0140EFDCConfiguration : IEntityTypeConfiguration<Reg0140EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0140EFDC> builder)
        {
            builder.HasKey(_0140 => _0140.Id);
            builder.Property(_0140 => _0140.Reg).HasMaxLength(4).HasDefaultValue("0140").IsRequired();
            builder.Property(_0140 => _0140.CodEstab).HasMaxLength(60);
            builder.Property(_0140 => _0140.Nome).HasMaxLength(100).IsRequired();
            builder.Property(_0140 => _0140.CNPJ).HasMaxLength(14).IsRequired();
            builder.Property(_0140 => _0140.UF).HasMaxLength(2).IsRequired();
            builder.Property(_0140 => _0140.IE).HasMaxLength(14);
            builder.Property(_0140 => _0140.MunicipioId).IsRequired();
            builder.Property(_0140 => _0140.IM).HasMaxLength(255);
            builder.Property(_0140 => _0140.Suframa).HasMaxLength(9);
            builder.Property(_0140 => _0140.DtIni).IsRequired();
            builder.HasOne(_0140 => _0140.PessoaJuridica);
            builder.HasOne(_0140 => _0140.User);
        }
    }
}
