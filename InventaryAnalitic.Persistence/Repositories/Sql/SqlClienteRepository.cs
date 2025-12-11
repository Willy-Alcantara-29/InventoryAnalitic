using InventaryAnalitic.Domain.Entities.Csv;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Repositories.Sql
{
    public class SqlClienteRepository : IClienteRepository
    {
        private readonly SourceDbContext _context;

        public SqlClienteRepository(SourceDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public Task AddAsync(Cliente cliente) => throw new NotImplementedException();
        public Task<Cliente> GetByIdAsync(int id) => throw new NotImplementedException();
    }
}
