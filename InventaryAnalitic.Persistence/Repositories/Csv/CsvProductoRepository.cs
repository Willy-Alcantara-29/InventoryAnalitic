using CsvHelper;
using CsvHelper.Configuration;
using InventaryAnalitic.Domain.Entities.Csv;
using InventaryAnalitic.Domain.Repositories;
using System.Globalization;

namespace InventaryAnalitic.Persistence.Repositories.Csv
{
    public class CsvProductoRepository : IProductoRepository
    {
        private readonly string _filePath;

        public CsvProductoRepository(string filePath)
        {
            _filePath = filePath;
        }

        public async Task<IEnumerable<Producto>> GetAllAsync()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Producto>();
            }

            using var reader = new StreamReader(_filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<Producto>().ToList();
            return await Task.FromResult(records);
        }

        public Task<Producto> GetByIdAsync(int id) => throw new NotImplementedException();
    }
}
