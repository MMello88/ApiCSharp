using lab.Domain.Entities.Cadastro.Referencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Referencias
{
    public class Ref311Configuration : IEntityTypeConfiguration<Ref311>
    {
        /*        public int Id { get; private set; }
        public string codigo { get; set; }
        public string versao { get; set; }
        public string leiaout { get; set; }
        public DateTime periodo { get; set; }*/
        public void Configure(EntityTypeBuilder<Ref311> builder)
        {
            builder.HasKey(r311 => r311.Id);
            builder.Property(r311 => r311.Codigo).HasMaxLength(5).IsRequired();
            builder.Property(r311 => r311.Versao).HasMaxLength(5).IsRequired();
            builder.Property(r311 => r311.Leiaout).HasMaxLength(100).IsRequired();
            builder.Property(r311 => r311.Periodo).IsRequired();
            builder.HasMany(m => m.Regs0000).WithOne(reg0000 => reg0000.Ref311);
        }
    }
}
