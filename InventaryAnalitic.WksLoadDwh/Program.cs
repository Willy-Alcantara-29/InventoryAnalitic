
using InventaryAnalitic.Domain.Entities.Dwh;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using InventaryAnalitic.Persistence.Repositories.Dwh;
using InventaryAnalitic.Persistence.Repositories.Sql;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.WksLoadDwh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);
            
            var configuration = builder.Configuration;

            // DbContexts
            builder.Services.AddDbContext<DwhDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DwhConnection")));

            builder.Services.AddDbContext<SourceDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SourceConnection")));

            // Repositories - Source (SQL)
            builder.Services.AddScoped<IClienteRepository, SqlClienteRepository>();
            builder.Services.AddScoped<IProductoRepository, SqlProductoRepository>();
            builder.Services.AddScoped<SqlVentaRepository>();
            builder.Services.AddScoped<SqlFuenteRepository>();
            builder.Services.AddScoped<IEmpleadoRepository, SqlEmpleadoRepository>();

            // Repositories - Target
            builder.Services.AddScoped<IDimClienteRepository, DimClienteRepository>();
            builder.Services.AddScoped<IDimProductoRepository, DimProductoRepository>();
            builder.Services.AddScoped<IDimFuenteRepository, DimFuenteRepository>();
            builder.Services.AddScoped<IDimFechaRepository, DimFechaRepository>();
            builder.Services.AddScoped<IDimEmpleadoRepository, DimEmpleadoRepository>();
            
            builder.Services.AddScoped<IFactRepository<FactVentas>, FactVentasRepository>();
            builder.Services.AddScoped<IFactRepository<FactOpiniones>, FactOpinionesRepository>();

            // Services
            builder.Services.AddScoped<EtlService>();

            builder.Services.AddHostedService<Worker>();

            var host = builder.Build();
            
            // Ensure DWH Database Created
            using (var scope = host.Services.CreateScope())
            {
                try 
                {
                    var db = scope.ServiceProvider.GetRequiredService<DwhDbContext>();
                    db.Database.EnsureCreated();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating database: {ex.Message}");
                }
            }

            host.Run();
        }
    }
}