using lab.Domain.Entities.Bloco.bA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.BlocoA
{
	public class RegA170EFDCConfiguration : IEntityTypeConfiguration<RegA170EFDC>
	{
		public void Configure(EntityTypeBuilder<RegA170EFDC> builder)
		{
			builder.HasKey(_A170 => _A170.Id);
			builder.Property(_A170 => _A170.Reg).HasMaxLength(4).HasDefaultValue("A170").IsRequired();
			builder.Property(_A170 => _A170.NumItem).HasMaxLength(4).IsRequired();
			builder.Property(_A170 => _A170.Reg0200EFDC).IsRequired();
			builder.Property(_A170 => _A170.DescricaoComplementar).HasMaxLength(255);
			builder.Property(_A170 => _A170.VlItem).HasColumnType("decimal(18, 2)").IsRequired();
			builder.Property(_A170 => _A170.VlDesconto).HasColumnType("decimal(18, 2)");
			builder.Property(_A170 => _A170.Ref433).IsRequired();
			builder.Property(_A170 => _A170.VlBcPis).HasColumnType("decimal(18, 2)");
			builder.Property(_A170 => _A170.VlAliqPis).HasColumnType("decimal(18, 2)");
			builder.Property(_A170 => _A170.VlPis).HasColumnType("decimal(18, 2)");
			builder.Property(_A170 => _A170.Ref434).IsRequired();
			builder.Property(_A170 => _A170.VlBcCofins).HasColumnType("decimal(18, 2)");
			builder.Property(_A170 => _A170.VlAliqCofins).HasColumnType("decimal(18, 2)");
			builder.Property(_A170 => _A170.VlCofins).HasColumnType("decimal(18, 2)");
			builder.HasOne(_A170 => _A170.RegA100EFDC).WithMany(_A100 => _A100.RegsA170EFDC);
		}
	}
}
