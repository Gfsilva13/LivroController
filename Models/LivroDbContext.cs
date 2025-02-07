using Microsoft.EntityFrameworkCore;

namespace LivroController.Models
{
    public class LivroDbContext : DbContext 
    {
        public DbSet<Livro> Livros { get; set; }
        public LivroDbContext(DbContextOptions<LivroDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Definir a string de conexão com o banco de dados do Azure
            optionsBuilder.UseSqlServer("(LocalDB)\\MSSQLLocalDB\Biblioteca");
        }
    }
}
