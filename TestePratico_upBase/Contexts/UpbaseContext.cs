using Microsoft.EntityFrameworkCore;
using TestePratico_upBase.Domains;

namespace TestePratico_upBase.Contexts
{
    public class UpbaseContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Aluno> Aluno { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2B634JF; Database=UpBase; user id=sa; Pwd=Senai@134; TrustServerCertificate = True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
