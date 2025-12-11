using InventaryAnalitic.Domain.Entities.Dwh;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IFactRepository<T> where T : class
    {
        Task LoadAsync(IEnumerable<T> data);
        Task CleanAsync();
    }
}
