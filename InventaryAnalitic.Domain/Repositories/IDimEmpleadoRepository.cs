using InventaryAnalitic.Domain.Entities.Dwh;

namespace InventaryAnalitic.Domain.Repositories
{
    public interface IDimEmpleadoRepository
    {
        Task LoadAsync(IEnumerable<DimEmpleado> empleados);
    }
}
