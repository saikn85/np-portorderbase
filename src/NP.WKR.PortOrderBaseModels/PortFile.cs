using NP.WKR.PortOrderBase.Models.PortFileStruct;

namespace NP.WKR.PortOrderBase.Models;

/// <summary>
/// Path representing the actual Port Order Type
/// </summary>
public sealed class PortFile
{
    /// <summary>
    /// Root of the Port File Directory
    /// </summary>
    public required string Root { get; set; }
    
    /// <summary>
    /// Path for all Port Order Requests
    /// </summary>
    public PortFileType? Requests { get; set; }

    /// <summary>
    /// Path for all Port Order Responses
    /// </summary>
    public PortFileType? Responses { get; set; }
}
