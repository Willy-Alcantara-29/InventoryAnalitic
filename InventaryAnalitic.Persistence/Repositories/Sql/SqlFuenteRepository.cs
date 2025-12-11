using InventaryAnalitic.Domain.Entities.Csv;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Repositories.Sql
{
    public class SqlFuenteRepository
    {
        private readonly SourceDbContext _context;

        public SqlFuenteRepository(SourceDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FuenteDato>> GetAllAsync()
        {
            return await _context.Fuentes.ToListAsync();
        }
    }
}
