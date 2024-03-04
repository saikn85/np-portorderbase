using NP.WKR.PortOrderBase.Models.PortFileActions;

namespace NP.WKR.PortOrderBase.Models.PortFileStruct;

/// <summary>
/// Represents the Port Order File Type
/// </summary>
public sealed class PortFileType
{
    /// <summary>
    /// Path 
    /// </summary>
    public PortFileTypeState? Requests { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public PortFileTypeState? Responses { get; set; }
}
