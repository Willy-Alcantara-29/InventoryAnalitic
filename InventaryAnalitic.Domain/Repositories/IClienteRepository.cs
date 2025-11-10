using InventaryAnalitic.Domain.Entities.Csv;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> GetByIdAsync(int id);
        Task<IEnumerable<Cliente>> GetAllAsync();
        Task AddAsync(Cliente cliente);
    }
}