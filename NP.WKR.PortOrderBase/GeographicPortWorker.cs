namespace NP.WKR.PortOrderBase
{
    public class GeographicPortWorker(ILogger<GeographicPortWorker> logger, IConfiguration config) : BackgroundService
    {
        private readonly ILogger<GeographicPortWorker> _logger = logger;
        private readonly IConfiguration _config = config;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
