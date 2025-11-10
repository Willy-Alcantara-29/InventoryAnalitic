using InventaryAnalitic.Domain.Entities.Csv;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IFuenteDatoRepository
    {
        Task<IEnumerable<FuenteDato>> GetAllAsync();
    }
}