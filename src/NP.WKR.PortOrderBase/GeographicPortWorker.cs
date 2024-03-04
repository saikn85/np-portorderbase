using Microsoft.Extensions.Configuration;
using NP.WKR.PortOrderBase.Models;

namespace NP.WKR.PortOrderBase;

/// <summary>
/// Worker Service that will read a
/// </summary>
/// <param name="logger"></param>
/// <param name="config"></param>
public class GeographicPortWorker(ILogger<GeographicPortWorker> logger, IConfiguration config) : BackgroundService
{
    private readonly int _defautlSleepInterval = 5;
    private readonly ILogger<GeographicPortWorker> _logger = logger;
    private readonly IConfiguration _config = config;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        int sleepInterval = (_config.GetValue<ushort?>("WRK_SleepInterval") ?? _defautlSleepInterval) * 60000;
        
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(sleepInterval, stoppingToken);
        }
    }
}
