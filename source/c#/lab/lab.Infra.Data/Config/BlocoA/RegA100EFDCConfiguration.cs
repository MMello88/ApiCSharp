using lab.Domain.Entities.Bloco.bA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.BlocoA
{
    public class RegA100EFDCConfiguration : IEntityTypeConfiguration<RegA100EFDC>
    {
        public void Configure(EntityTypeBuilder<RegA100EFDC> builder)
        {
            builder.HasKey(_A100 => _A100.Id);
            builder.Property(_A100 => _A100.Reg).HasMaxLength(4).HasDefaultValue("A100").IsRequired();
            builder.Property(_A100 => _A100.IndicadorTipoOperacao).IsRequired();
            builder.Property(_A100 => _A100.IndicadorEmitenteDocumento).IsRequired();
            builder.Property(_A100 => _A100.SituacaoDocumentoFiscal).IsRequired();
            builder.Property(_A100 => _A100.Ser).HasMaxLength(20);
            builder.Property(_A100 => _A100.Sub).HasMaxLength(20);
            builder.Property(_A100 => _A100.NumDoc).HasMaxLength(60).IsRequired();
            builder.Property(_A100 => _A100.ChaveEletronica).HasMaxLength(60);
            builder.Property(_A100 => _A100.DtEmissaoDoc).IsRequired();
            builder.Property(_A100 => _A100.VlDocumento).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(_A100 => _A100.IndicadorTipoPagamento).IsRequired();
            builder.Property(_A100 => _A100.VlDesconto).HasColumnType("decimal(18, 2)");
            builder.Property(_A100 => _A100.VlBcPis).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(_A100 => _A100.VlPis).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(_A100 => _A100.VlBcCofins).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(_A100 => _A100.VlPisRetido).HasColumnType("decimal(18, 2)");
            builder.Property(_A100 => _A100.VlConfinsRetido).HasColumnType("decimal(18, 2)");
            builder.Property(_A100 => _A100.VlIss).HasColumnType("decimal(18, 2)");
            builder.Property(_A100 => _A100.DtIni).IsRequired();
			builder.HasMany(_A100 => _A100.RegsA110EFDC).WithOne(_A110 => _A110.RegA100EFDC);
			builder.HasMany(_A100 => _A100.RegsA111EFDC).WithOne(_A111 => _A111.RegA100EFDC);
			builder.HasMany(_A100 => _A100.RegsA120EFDC).WithOne(_A120 => _A120.RegA100EFDC);
			builder.HasMany(_A100 => _A100.RegsA170EFDC).WithOne(_A170 => _A170.RegA100EFDC);
        }
    }
}
