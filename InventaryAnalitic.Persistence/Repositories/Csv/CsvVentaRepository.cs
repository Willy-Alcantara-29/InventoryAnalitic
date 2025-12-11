using CsvHelper;
using CsvHelper.Configuration;
using InventaryAnalitic.Domain.Entities.Csv;
using InventaryAnalitic.Domain.Repositories;
using System.Globalization;

namespace InventaryAnalitic.Persistence.Repositories.Csv
{
    public class CsvVentaRepository : IVentaRepository
    {
        private readonly string _filePath;

        public CsvVentaRepository(string filePath)
        {
            _filePath = filePath;
        }

        public async Task<IEnumerable<Venta>> GetAllAsync()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Venta>();
            }

            using var reader = new StreamReader(_filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<Venta>().ToList();
            return await Task.FromResult(records);
        }

        public Task<IEnumerable<Venta>> GetByDateRangeAsync(DateTime startDate, DateTime endDate) => throw new NotImplementedException();

        public Task AddAsync(Venta venta) => throw new NotImplementedException();
    }
}
