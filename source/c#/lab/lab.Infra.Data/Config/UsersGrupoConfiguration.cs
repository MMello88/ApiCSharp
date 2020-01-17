using lab.Domain.Entities.Enums;
using lab.Domain.Entities.Registro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config
{
    public class UsersGrupoConfiguration : IEntityTypeConfiguration<UsersGrupo>
    {
        public void Configure(EntityTypeBuilder<UsersGrupo> builder)
        {
            builder.HasKey(ug => new { ug.UserId, ug.GrupoUserId });
            builder.Property(ug => ug.Ativo).IsRequired().HasDefaultValue(AtivoEnum.Ativo);
        }
    }
}
