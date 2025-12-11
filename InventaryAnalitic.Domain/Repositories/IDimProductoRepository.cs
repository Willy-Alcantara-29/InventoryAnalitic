using InventaryAnalitic.Domain.Entities.Dwh;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IDimProductoRepository
    {
        Task LoadAsync(IEnumerable<DimProducto> productos);
    }
}
