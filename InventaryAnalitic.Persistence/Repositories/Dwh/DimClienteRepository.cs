using InventaryAnalitic.Domain.Entities.Dwh;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Repositories.Dwh
{
    public class DimClienteRepository : IDimClienteRepository
    {
        private readonly DwhDbContext _context;

        public DimClienteRepository(DwhDbContext context)
        {
            _context = context;
        }

        public async Task LoadAsync(IEnumerable<DimCliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                var existing = await _context.DimCliente
                    .FirstOrDefaultAsync(c => c.ID_Cliente_Fuente == cliente.ID_Cliente_Fuente);

                if (existing != null)
                {
                    existing.NombreCliente = cliente.NombreCliente;
                    existing.Pais = cliente.Pais;
                    existing.Ciudad = cliente.Ciudad;
                    existing.RangoEdad = cliente.RangoEdad;
                    existing.TipoCliente = cliente.TipoCliente;
                    _context.DimCliente.Update(existing);
                }
                else
                {
                    await _context.DimCliente.AddAsync(cliente);
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
