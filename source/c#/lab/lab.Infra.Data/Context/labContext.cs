using lab.Domain.Entities.Registro;
using lab.Domain.Entities.Cadastro.Auxiliar;
using lab.Infra.Data.Config;
using Microsoft.EntityFrameworkCore;
using lab.Infra.Data.Config.Referencias;
using lab.Domain.Entities.Cadastro.Referencias;
using lab.Infra.Data.Config.Bloco0;
using lab.Domain.Entities.Bloco.b0;

namespace lab.Infra.Data.Context
{
    public class labContext : DbContext
    {
        DbSet<PessoaFisica> PessoasFisica { get; set; }
        DbSet<PessoaJuridica> PessoasJuridica { get; set; }
        DbSet<Municipio> Municipios { get; set; }
        DbSet<Pais> Paises { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<GrupoUser> GrupoUsers { get; set; }
        DbSet<UsersGrupo> UsersGrupo { get; set; }
        DbSet<Ref311> Ref311 { get; set; }
        DbSet<Reg0000EFDC> Regs0000EFDC { get; set; }
        

        public labContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PaisConfiguration());
            modelBuilder.ApplyConfiguration(new MunicipioConfiguration());
            modelBuilder.ApplyConfiguration(new Ref311Configuration());
            modelBuilder.ApplyConfiguration(new PessoaFisicaConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaJuridicaConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoUserConfiguration());
            modelBuilder.ApplyConfiguration(new UsersGrupoConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0000EFDCConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        /*
         * Esta é uma maneira convencional. De outra forma é criar para cada configuração uma classe
         * e instacia-la aqui no construtor
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaFisica>(entt => {
                entt.HasKey(u => u.Id);
                entt.Property(u => u.Nome)
                        .IsRequired()
                        .HasMaxLength(150);
            });
            base.OnModelCreating(modelBuilder);
        }
        */
    }
}