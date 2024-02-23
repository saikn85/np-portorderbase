namespace NP.WKR.PortOrderReader
{
    public class GeographicPortWorker(ILogger<GeographicPortWorker> logger) : BackgroundService
    {
        private readonly ILogger<GeographicPortWorker> _logger = logger;

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
