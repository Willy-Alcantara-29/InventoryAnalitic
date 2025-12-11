using InventaryAnalitic.Domain.Entities.Dwh;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Repositories.Dwh
{
    public class FactOpinionesRepository : IFactRepository<FactOpiniones>
    {
        private readonly DwhDbContext _context;

        public FactOpinionesRepository(DwhDbContext context)
        {
            _context = context;
        }

        public async Task CleanAsync()
        {
            await _context.Database.ExecuteSqlRawAsync("TRUNCATE TABLE Fact_Opiniones");

        }

        public async Task LoadAsync(IEnumerable<FactOpiniones> data)
        {
            await _context.FactOpiniones.AddRangeAsync(data);
            await _context.SaveChangesAsync();
        }
    }
}
