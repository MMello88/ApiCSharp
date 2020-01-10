using lab.Domain.Entities.Registro;
using Microsoft.EntityFrameworkCore;

namespace lab.Infra.Data.Context
{
    public class labContext : DbContext
    {
        DbSet<PessoaFisica> PessoaFisicas { get; set; }

        public labContext(DbContextOptions options) : base(options)
        {

        }
    }
}
