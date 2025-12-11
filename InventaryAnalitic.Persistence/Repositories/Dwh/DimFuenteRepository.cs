using InventaryAnalitic.Domain.Entities.Dwh;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Repositories.Dwh
{
    public class DimFuenteRepository : IDimFuenteRepository
    {
        private readonly DwhDbContext _context;

        public DimFuenteRepository(DwhDbContext context)
        {
            _context = context;
        }

        public async Task LoadAsync(IEnumerable<DimFuente> fuentes)
        {
            foreach (var fuente in fuentes)
            {
                var existing = await _context.DimFuente
                    .FirstOrDefaultAsync(f => f.NombreFuente == fuente.NombreFuente && f.Canal == fuente.Canal);

                if (existing == null)
                {
                    await _context.DimFuente.AddAsync(fuente);
                }
            }
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DimFuente>> GetAllAsync()
        {
            return await _context.DimFuente.ToListAsync();
        }
    }
}
