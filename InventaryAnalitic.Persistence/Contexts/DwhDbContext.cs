using InventaryAnalitic.Domain.Entities.Dwh;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Contexts
{
    public class DwhDbContext : DbContext
    {
        public DwhDbContext(DbContextOptions<DwhDbContext> options) : base(options)
        {
        }

        public DbSet<DimCliente> DimCliente { get; set; }
        public DbSet<DimEmpleado> DimEmpleado { get; set; }
        public DbSet<DimProducto> DimProducto { get; set; }
        public DbSet<DimFecha> DimFecha { get; set; }
        public DbSet<DimFuente> DimFuente { get; set; }
        public DbSet<DimSentimiento> DimSentimiento { get; set; }
        public DbSet<FactOpiniones> FactOpiniones { get; set; }
        public DbSet<FactVentas> FactVentas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<DimCliente>().HasKey(e => e.ID_Cliente);
            modelBuilder.Entity<DimEmpleado>().HasKey(e => e.ID_Empleado);
            modelBuilder.Entity<DimProducto>().HasKey(e => e.ID_Producto);
            modelBuilder.Entity<DimFecha>().HasKey(e => e.ID_Fecha);
            modelBuilder.Entity<DimFuente>().HasKey(e => e.ID_Fuente);
            modelBuilder.Entity<DimSentimiento>().HasKey(e => e.ID_Sentimiento);
            modelBuilder.Entity<FactOpiniones>().HasKey(e => e.ID_Opinion);
            modelBuilder.Entity<FactVentas>().HasKey(e => e.ID_Venta);
        }
    }
}
