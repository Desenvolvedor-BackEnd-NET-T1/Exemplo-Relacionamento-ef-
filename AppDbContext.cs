using Microsoft.EntityFrameworkCore;
using ProjetoFimModulo.Entidades;

namespace ProjetoFimModulo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>( c=> {
                
                
                c.HasMany(c => c.Chamados) 
                .WithOne(ch => ch.Categoria)
                .HasForeignKey(ch => ch.CategoriaId);
                
            });

            // modelBuilder.Entity<Chamado>( c => {
            //     c.HasOne(ch => ch.Categoria)
            //     .WithMany(c => c.Chamados)
            //     .HasForeignKey(ch => ch.CategoriaId);
            // });


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}