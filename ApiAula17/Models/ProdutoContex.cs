using Microsoft.EntityFrameworkCore;

namespace ApiAula17.Models
{
    public class ProdutoContex : DbContext
    {
        public ProdutoContex(DbContextOptions<ProdutoContex>options): base(options) { }

        public DbSet<Controlador>Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Controlador>().ToTable("produtos");
        }
    }
}
