using NP.WKR.PortOrderBase.Models.PortFileActions;

namespace NP.WKR.PortOrderBase.Models.PortFileStruct;

/// <summary>
/// Path representing the Port Order File Type
/// </summary>
public sealed class PortFileType
{
    /// <summary>
    /// Path for all Port Order Requests
    /// </summary>
    public PortFileTypeState? Requests { get; set; }

    /// <summary>
    /// Path for all Port Order Responses
    /// </summary>
    public PortFileTypeState? Responses { get; set; }
}
