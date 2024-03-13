namespace NP.WKR.PortOrderBase.Service.Interfaces;

public class PortOrderReader : IPortOrderReader
{
    public async Task ProcessGeoPortsAsync(CancellationToken token)
    {
        Console.WriteLine("Called");

        return;
    }
}
