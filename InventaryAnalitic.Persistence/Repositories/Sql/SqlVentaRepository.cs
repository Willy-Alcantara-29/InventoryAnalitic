using InventaryAnalitic.Domain.Entities.Csv;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Repositories.Sql
{
    public class SqlVentaRepository : IVentaRepository
    {
        private readonly SourceDbContext _context;

        public SqlVentaRepository(SourceDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Venta>> GetAllAsync()
        {
            return await _context.Ventas.ToListAsync();
        }

        public Task<IEnumerable<Venta>> GetByDateRangeAsync(DateTime startDate, DateTime endDate) => throw new NotImplementedException();

        public Task AddAsync(Venta venta) => throw new NotImplementedException();
    }
}
