using lab.Domain.Entities.Registro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config
{
    public class GrupoUserConfiguration : IEntityTypeConfiguration<GrupoUser>
    {
        public void Configure(EntityTypeBuilder<GrupoUser> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Nome).HasMaxLength(350).IsRequired();
            builder.HasMany(g => g.UsersGrupo).WithOne(ug => ug.GrupoUser);
        }
    }
}
