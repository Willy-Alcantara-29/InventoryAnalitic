using InventaryAnalitic.Domain.Entities.Dwh;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IDimClienteRepository
    {
        Task LoadAsync(IEnumerable<DimCliente> clientes);
    }
}
