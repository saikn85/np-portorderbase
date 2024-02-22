namespace NP.WKR.PortOrderReader
{
    public class GeographicPortWorker : BackgroundService
    {
        private readonly ILogger<GeographicPortWorker> _logger;

        public GeographicPortWorker(ILogger<GeographicPortWorker> logger)
        {
            _logger = logger;
        }

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
