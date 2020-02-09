using lab.Domain.Entities.Bloco.bA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.BlocoA
{
    public class RegA120EFDCConfiguration : IEntityTypeConfiguration<RegA120EFDC>
    {
        public void Configure(EntityTypeBuilder<RegA120EFDC> builder)
        {
            builder.HasKey(_A120 => _A120.Id);
            builder.Property(_A120 => _A120.Reg).HasMaxLength(4).HasDefaultValue("A120").IsRequired();
			builder.Property(_A120 => _A120.VlTotalServico).HasColumnType("decimal(18, 2)").IsRequired();
			builder.Property(_A120 => _A120.VlBcPis).HasColumnType("decimal(18, 2)").IsRequired();
			builder.Property(_A120 => _A120.VlPisImportacao).HasColumnType("decimal(18, 2)");
            builder.Property(_A120 => _A120.DtPgtoPisImportacao);
			builder.Property(_A120 => _A120.VlBcCofins).HasColumnType("decimal(18, 2)").IsRequired();
			builder.Property(_A120 => _A120.VlCofinsImportacao).HasColumnType("decimal(18, 2)");
			builder.Property(_A120 => _A120.DtPgtoCofinsImportacao);
			builder.Property(_A120 => _A120.IndicadorLocalExecucaoServico).IsRequired();
			builder.HasOne(_A120 => _A120.RegA100EFDC).WithMany(_A100 => _A100.RegsA120EFDC);
        }
    }
}
