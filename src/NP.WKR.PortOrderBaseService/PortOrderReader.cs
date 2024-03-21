using NP.WKR.PortOrderBase.Models;
using NP.WKR.PortOrderBase.Models.Common;
using NP.WKR.PortOrderBase.Service.Interfaces;
using NP.WKR.PortOrderBase.Service.Ultities;

namespace NP.WKR.PortOrderBase.Service;

/// <summary>
/// 
/// </summary>
public class PortOrderReader : IPortOrderReader
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="token"></param>
    /// <returns></returns>
    public async Task ProcessGeoPortsAsync(CancellationToken token)
    {
        try
        {
            PortFile loc = ConfigCache.TryGet(ConfigType.GeoPorts, out var geoPorts)
                ? (geoPorts as PortFile)! // New syntax to that tell us about the object not being null
                : throw new Exception("Failed to get Port File Locations");
            string baseDir = ConfigCache.TryGet(ConfigType.BaseWorkDirectory, out var rootDir)
                ? (rootDir as string)! // New syntax to that tell us about the object not being null
                : throw new Exception("Failed to get Port File Locations");

        }
        catch (Exception)
        {
            return;
        }
    }
}
