using InventaryAnalitic.Domain.Entities.Csv;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IEncuestaRepository
    {
        Task<IEnumerable<Encuesta>> GetUnprocessedAsync();
    }
}