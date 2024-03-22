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
            PortFile portFile = ConfigCache.TryGet(ConfigType.GeoPorts, out var geoPorts)
                ? (geoPorts as PortFile)! // ensures the object is not null
                : throw new Exception($"{nameof(ProcessGeoPortsAsync)} Errored: {nameof(ConfigTypeError.GEO_PORT_FILE_ERROR)}");
            string rootDir = ConfigCache.TryGet(ConfigType.BaseWorkDirectory, out var baseDir)
                ? (baseDir as string)! // ensures the object is not null
                : throw new Exception($"{nameof(ProcessGeoPortsAsync)} Errored: {nameof(ConfigTypeError.BASE_WORK_DIR_ERROR)}");

            string reqPath = Path.Combine(
                rootDir,
                portFile.Root,
                nameof(portFile.Requests),
                nameof(portFile.Requests.Received));
            string resPath = Path.Combine(
                rootDir,
                portFile.Root,
                nameof(portFile.Responses),
                nameof(portFile.Responses.Received));

            DirectoryInfo requests = new(reqPath);
            DirectoryInfo responses = new(resPath);


        }
        catch (Exception)
        {
            return;
        }
    }
}
