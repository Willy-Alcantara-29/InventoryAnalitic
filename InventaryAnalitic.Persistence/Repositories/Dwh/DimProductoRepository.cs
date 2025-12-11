using InventaryAnalitic.Domain.Entities.Dwh;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InventaryAnalitic.Persistence.Repositories.Dwh
{
    public class DimProductoRepository : IDimProductoRepository
    {
        private readonly DwhDbContext _context;

        public DimProductoRepository(DwhDbContext context)
        {
            _context = context;
        }

        public async Task LoadAsync(IEnumerable<DimProducto> productos)
        {
            foreach (var producto in productos)
            {
                var existing = await _context.DimProducto
                    .FirstOrDefaultAsync(p => p.SKU_Producto == producto.SKU_Producto);

                if (existing != null)
                {
                    existing.NombreProducto = producto.NombreProducto;
                    existing.CategoriaProducto = producto.CategoriaProducto;
                    existing.Marca = producto.Marca;
                    _context.DimProducto.Update(existing);
                }
                else
                {
                    await _context.DimProducto.AddAsync(producto);
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
