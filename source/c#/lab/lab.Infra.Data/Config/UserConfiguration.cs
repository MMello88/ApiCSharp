using lab.Domain.Entities.Enums;
using lab.Domain.Entities.Registro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(350).IsRequired();
            builder.Property(u => u.Sobrenome).HasMaxLength(250).IsRequired();
            builder.Property(u => u.DataNascimento).IsRequired();
            builder.Property(u => u.Ativo).IsRequired().HasDefaultValue(AtivoEnum.Ativo);
            builder.Property(u => u.Criacao).IsRequired();
            builder.Property(u => u.Usuario).HasMaxLength(250).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(250).IsRequired();
            builder.Property(u => u.Senha).HasMaxLength(64).IsRequired();
            builder.HasMany(u => u.UsersGrupo).WithOne(ug => ug.User);
        }
    }
}
