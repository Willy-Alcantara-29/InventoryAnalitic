using InventaryAnalitic.Domain.Entities.Csv;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IVentaRepository
    {
        Task<IEnumerable<Venta>> GetAllAsync();
        Task<IEnumerable<Venta>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task AddAsync(Venta venta);
    }
}