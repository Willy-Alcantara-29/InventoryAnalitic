using InventaryAnalitic.Domain.Entities.Csv;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IComentarioSocialRepository
    {
        Task<IEnumerable<ComentarioSocial>> GetUnprocessedAsync();
        Task AddAsync(ComentarioSocial comentario);
    }
}