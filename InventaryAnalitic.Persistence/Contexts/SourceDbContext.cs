using InventaryAnalitic.Domain.Entities.Csv;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Contexts
{
    public class SourceDbContext : DbContext
    {
        public SourceDbContext(DbContextOptions<SourceDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<FuenteDato> Fuentes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Encuesta> Encuestas { get; set; }
        public DbSet<ComentarioSocial> Comentarios { get; set; }
        public DbSet<ResenaWeb> Resenas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
