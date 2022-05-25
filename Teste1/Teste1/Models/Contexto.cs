using Microsoft.EntityFrameworkCore;

namespace Teste1.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }
        public DbSet<Vagas> Vagas { get; set; }
        public DbSet<Curriculos> Curriculos { get; set; }
    }
}
