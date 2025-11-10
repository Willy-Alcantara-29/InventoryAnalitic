using InventaryAnalitic.Domain.Entities.Csv;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IProductoRepository
    {
        Task<Producto> GetByIdAsync(int id);
        Task<IEnumerable<Producto>> GetAllAsync();
    }
}