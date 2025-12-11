using InventaryAnalitic.Domain.Entities.Dwh;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Repositories.Dwh
{
    public class FactVentasRepository : IFactRepository<FactVentas>
    {
        private readonly DwhDbContext _context;

        public FactVentasRepository(DwhDbContext context)
        {
            _context = context;
        }

        public async Task CleanAsync()
        {
            // Using ExecuteSqlRaw to Truncate. 
            // Note: Truncate might fail if FK constraints exist without cascading. 
            // But usually in DWH Starschema, Facts are children, so Truncate Fact is fine.
            await _context.Database.ExecuteSqlRawAsync("TRUNCATE TABLE Fact_Ventas");

        }

        public async Task LoadAsync(IEnumerable<FactVentas> data)
        {
            await _context.FactVentas.AddRangeAsync(data);
            await _context.SaveChangesAsync();
        }
    }
}
