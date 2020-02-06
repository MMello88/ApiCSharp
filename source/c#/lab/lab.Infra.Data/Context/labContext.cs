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
        DbSet<Reg0001EFDC> Regs0001EFDC { get; set; }
        DbSet<Reg0035EFDC> Regs0035EFDC { get; set; }
        DbSet<Reg0100EFDC> Regs0100EFDC { get; set; }
        DbSet<Reg0110EFDC> Regs0110EFDC { get; set; }
        DbSet<Reg0111EFDC> Regs0111EFDC { get; set; }
        DbSet<Reg0120EFDC> Regs0120EFDC { get; set; }
        DbSet<Reg0140EFDC> Regs0140EFDC { get; set; }
        DbSet<Reg0145EFDC> Regs0145EFDC { get; set; }
        DbSet<Reg0150EFDC> Regs0150EFDC { get; set; }
        DbSet<Reg0190EFDC> Regs0190EFDC { get; set; }
        DbSet<Reg0200EFDC> Regs0200EFDC { get; set; }
        DbSet<Reg0400EFDC> Regs0400EFDC { get; set; }
        DbSet<Reg0450EFDC> Regs0450EFDC { get; set; }
        DbSet<Reg0500EFDC> Regs0500EFDC { get; set; }
        DbSet<Reg0600EFDC> Regs0600EFDC { get; set; }


        public labContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Ref311Configuration());
            modelBuilder.ApplyConfiguration(new Ref411Configuration());
            modelBuilder.ApplyConfiguration(new Ref412Configuration());
            modelBuilder.ApplyConfiguration(new Ref412Configuration());
            modelBuilder.ApplyConfiguration(new Ref422Configuration());
            modelBuilder.ApplyConfiguration(new Ref4310Configuration());
            modelBuilder.ApplyConfiguration(new Ref4311Configuration());
            modelBuilder.ApplyConfiguration(new Ref4312Configuration());
            modelBuilder.ApplyConfiguration(new Ref4313Configuration());
            modelBuilder.ApplyConfiguration(new Ref4314Configuration());
            modelBuilder.ApplyConfiguration(new Ref4315Configuration());
            modelBuilder.ApplyConfiguration(new Ref4316Configuration());
            modelBuilder.ApplyConfiguration(new Ref4317Configuration());
            modelBuilder.ApplyConfiguration(new Ref4318Configuration());
            modelBuilder.ApplyConfiguration(new Ref431Configuration());
            modelBuilder.ApplyConfiguration(new Ref432Configuration());
            modelBuilder.ApplyConfiguration(new Ref433Configuration());
            modelBuilder.ApplyConfiguration(new Ref434Configuration());
            modelBuilder.ApplyConfiguration(new Ref435Configuration());
            modelBuilder.ApplyConfiguration(new Ref436Configuration());
            modelBuilder.ApplyConfiguration(new Ref437Configuration());
            modelBuilder.ApplyConfiguration(new Ref438Configuration());
            modelBuilder.ApplyConfiguration(new Ref439Configuration());
            modelBuilder.ApplyConfiguration(new Ref511Configuration());
            modelBuilder.ApplyConfiguration(new Ref512Configuration());
            modelBuilder.ApplyConfiguration(new Ref711Configuration());
            modelBuilder.ApplyConfiguration(new Ref712Configuration());
            modelBuilder.ApplyConfiguration(new Ref713Configuration());
            modelBuilder.ApplyConfiguration(new Ref714Configuration());


            modelBuilder.ApplyConfiguration(new PaisConfiguration());
            modelBuilder.ApplyConfiguration(new MunicipioConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaFisicaConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaJuridicaConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoUserConfiguration());
            modelBuilder.ApplyConfiguration(new UsersGrupoConfiguration());
            
            modelBuilder.ApplyConfiguration(new Reg0000EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0001EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0100EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0110EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0111EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0120EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0140EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0145EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0150EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0190EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0200EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0400EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0450EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0500EFDCConfiguration());
            modelBuilder.ApplyConfiguration(new Reg0600EFDCConfiguration());

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