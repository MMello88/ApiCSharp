using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0208EFDCConfiguration : IEntityTypeConfiguration<Reg0208EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0208EFDC> builder)
        {
            builder.HasKey(_0208 => _0208.Id);
            builder.Property(_0208 => _0208.Reg).HasMaxLength(4).HasDefaultValue("0208").IsRequired();
            builder.Property(_0208 => _0208.CodTabIncidencia).IsRequired();
            builder.Property(_0208 => _0208.CodGrupo).HasMaxLength(2).IsRequired();
            builder.Property(_0208 => _0208.MarcaComercial).HasMaxLength(255).IsRequired();
        }
    }
}
