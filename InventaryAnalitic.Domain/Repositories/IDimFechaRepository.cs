using InventaryAnalitic.Domain.Entities.Dwh;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IDimFechaRepository
    {
        Task EnsureDateRangeAsync(int startYear, int endYear);
        Task<int> GetDateIdAsync(DateTime date);
    }
}
