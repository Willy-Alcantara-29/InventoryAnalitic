using InventaryAnalitic.Domain.Entities.Dwh;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Repositories.Dwh
{
    public class DimEmpleadoRepository : IDimEmpleadoRepository
    {
        private readonly DwhDbContext _context;

        public DimEmpleadoRepository(DwhDbContext context)
        {
            _context = context;
        }

        public async Task LoadAsync(IEnumerable<DimEmpleado> empleados)
        {
            foreach (var empleado in empleados)
            {
                var existing = await _context.DimEmpleado
                    .FirstOrDefaultAsync(e => e.ID_Empleado_Fuente == empleado.ID_Empleado_Fuente);

                if (existing != null)
                {
                    existing.NombreEmpleado = empleado.NombreEmpleado;
                    existing.Titulo = empleado.Titulo;
                    existing.Pais = empleado.Pais;
                    _context.DimEmpleado.Update(existing);
                }
                else
                {
                    await _context.DimEmpleado.AddAsync(empleado);
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
