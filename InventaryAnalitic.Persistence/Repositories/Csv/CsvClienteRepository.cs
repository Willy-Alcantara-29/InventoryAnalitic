using CsvHelper;
using CsvHelper.Configuration;
using InventaryAnalitic.Domain.Entities.Csv;
using InventaryAnalitic.Domain.Repositories;
using System.Globalization;

namespace InventaryAnalitic.Persistence.Repositories.Csv
{
    public class CsvClienteRepository : IClienteRepository
    {
        private readonly string _filePath;

        public CsvClienteRepository(string filePath)
        {
            _filePath = filePath;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Cliente>();
            }

            using var reader = new StreamReader(_filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<Cliente>().ToList();
            return await Task.FromResult(records);
        }

        public Task AddAsync(Cliente cliente) => throw new NotImplementedException();
        public Task<Cliente> GetByIdAsync(int id) => throw new NotImplementedException();
    }
}
