using Microsoft.EntityFrameworkCore;
using TiendaAPI.Models;


namespace TiendaAPI.Models
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Articulo> Articulos {get; set;}
        public DbSet<Categorias> Categorias {get; set;}
        public DbSet<Colores> Colores {get; set;}

        public DbSet<Sizes> Sizes {get;  set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Articulo>()
            .HasOne(u => u.Categoria)
            .WithMany()
            .HasForeignKey(u => u.IdCategoria);
            
            modelBuilder.Entity<Articulo>()
            .HasOne<Sizes>()
            .WithMany()
            .HasForeignKey(u => u.IdSizes);
            
            
            modelBuilder.Entity<Articulo>()
            .HasOne<Colores>()
            .WithMany()
            .HasForeignKey(u => u.IdColores);
            

        }

    }
}