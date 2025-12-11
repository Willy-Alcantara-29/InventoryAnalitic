using InventaryAnalitic.Domain.Entities.Csv;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Repositories.Sql
{
    public class SqlProductoRepository : IProductoRepository
    {
        private readonly SourceDbContext _context;

        public SqlProductoRepository(SourceDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> GetAllAsync()
        {
            return await _context.Productos.ToListAsync();
        }

        public Task<Producto> GetByIdAsync(int id) => throw new NotImplementedException();
    }
}
