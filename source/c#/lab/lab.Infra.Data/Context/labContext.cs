using lab.Domain.Entities.Registro;
using lab.Infra.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace lab.Infra.Data.Context
{
    public class labContext : DbContext
    {
        DbSet<PessoaFisica> PessoaFisicas { get; set; }

        public labContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaFisicaConfiguration());
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
