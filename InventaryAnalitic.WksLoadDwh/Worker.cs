

namespace InventaryAnalitic.WksLoadDwh
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _serviceProvider;

        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                using (var scope = _serviceProvider.CreateScope())
                {
                    try
                    {
                        var etlService = scope.ServiceProvider.GetRequiredService<EtlService>();
                        await etlService.RunEtlAsync();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error executing ETL Service");
                    }
                }

                _logger.LogInformation("ETL Cycle completed. Waiting for next cycle...");
                
                // Wait for 24 hours
                await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
            }
        }
    }
}
