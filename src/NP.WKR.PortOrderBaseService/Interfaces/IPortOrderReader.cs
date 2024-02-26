namespace NP.WKR.PortOrderBase.Service.Interfaces;

public interface IPortOrderReader
{
    public Task ReadRequestFileAsync(FileInfo fileInfo);
}
