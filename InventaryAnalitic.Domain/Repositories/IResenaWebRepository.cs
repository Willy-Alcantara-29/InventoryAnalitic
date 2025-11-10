using InventaryAnalitic.Domain.Entities.Csv;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IResenaWebRepository
    {
        Task<IEnumerable<ResenaWeb>> GetUnprocessedAsync();
    }
}