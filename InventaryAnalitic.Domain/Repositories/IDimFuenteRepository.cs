using InventaryAnalitic.Domain.Entities.Dwh;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IDimFuenteRepository
    {
        Task LoadAsync(IEnumerable<DimFuente> fuentes);
        Task<IEnumerable<DimFuente>> GetAllAsync();
    }
}
