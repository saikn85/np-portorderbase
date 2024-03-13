using NP.WKR.PortOrderBase.Models;
using NP.WKR.PortOrderBase.Models.Common;
using NP.WKR.PortOrderBase.Service.Interfaces;
using NP.WKR.PortOrderBase.Service.Ultities;

namespace NP.WKR.PortOrderBase;

/// <summary>
/// Worker Service that will read a
/// </summary>
/// <param name="logger"></param>
/// <param name="config"></param>
public class GeographicPortWorker(IConfiguration config, IPortOrderReader geoPortReader) : BackgroundService
{
    private readonly int _defautlSleepInterval = 5;
    private readonly IConfiguration _config = config;
    private readonly IPortOrderReader _geoPortReader = geoPortReader;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            int sleepInterval = (_config.GetValue<ushort?>("WRK_SleepInterval") ?? _defautlSleepInterval) * 60000;
            var workDir = _config.GetValue<string>("PortOrderBaseWorkDir") 
                ?? throw new Exception("Root Directory for File Processing is NULL!");
            ConfigCache.Add(ConfigType.BaseWorkDirectory, workDir);

            var geoPortsLoc = _config
                .GetSection("PortingConfig")
                .GetSection("GeoPorts")
                .Get<PortFile>()
                ?? throw new Exception("Geographic Port File Location is NULL!");
            ConfigCache.Add(ConfigType.GeoPorts, geoPortsLoc);

            var geoConfig = _config
                .GetSection("GeoConfig")
                .Get<GeoConfig>()
                ?? throw new Exception("Geographic Config is NULL!");
            ConfigCache.Add(ConfigType.GeoConfig, geoConfig);

            while (!stoppingToken.IsCancellationRequested)
            {
                await _geoPortReader.ProcessGeoPortsAsync(stoppingToken);
                await Task.Delay(sleepInterval, stoppingToken);
            }
        }
        catch (Exception)
        {
            // End the Task
            return;
        }
    }
}
