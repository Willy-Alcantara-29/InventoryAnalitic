using InventaryAnalitic.Domain.Entities.Dwh;
using InventaryAnalitic.Domain.Repositories;
using InventaryAnalitic.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace InventaryAnalitic.Persistence.Repositories.Dwh
{
    public class DimFechaRepository : IDimFechaRepository
    {
        private readonly DwhDbContext _context;

        public DimFechaRepository(DwhDbContext context)
        {
            _context = context;
        }

        public async Task EnsureDateRangeAsync(int startYear, int endYear)
        {
            // Simple check if year exists
            var start = new DateTime(startYear, 1, 1);
            var end = new DateTime(endYear, 12, 31);
            
            // In a real scenario, check if generated. For now, generate missing days.
            // Simplified: Generate if count is low for the range.
            var count = await _context.DimFecha.CountAsync(d => d.Anio >= startYear && d.Anio <= endYear);
            if (count > 360) return; // Assume already populated

            var dates = new List<DimFecha>();
            for (var date = start; date <= end; date = date.AddDays(1))
            {
               var id = int.Parse(date.ToString("yyyyMMdd"));
               if (await _context.DimFecha.AnyAsync(d => d.ID_Fecha == id)) continue;

               dates.Add(new DimFecha
               {
                   ID_Fecha = id,
                   FechaCompleta = date,
                   Anio = date.Year,
                   Mes = date.Month,
                   Trimestre = (date.Month - 1) / 3 + 1,
                   DiaDelMes = date.Day,
                   DiaDeLaSemana = (int)date.DayOfWeek,
                   NombreMes = date.ToString("MMMM", CultureInfo.InvariantCulture),
                   NombreDia = date.ToString("dddd", CultureInfo.InvariantCulture)
               });
            }

            if (dates.Any())
            {
                await _context.DimFecha.AddRangeAsync(dates);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> GetDateIdAsync(DateTime date)
        {
            return int.Parse(date.ToString("yyyyMMdd"));
        }
    }
}
