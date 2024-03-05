using NP.WKR.PortOrderBase.Models.PortFileStruct;

namespace NP.WKR.PortOrderBase.Models;

/// <summary>
/// Path representing the actual Port Order Type
/// </summary>
public sealed class PortFile
{
    /// <summary>
    /// Path for all Activation related Port Orders
    /// </summary>
    public PortFileType? Activation { get; set; }

    /// <summary>
    /// Path for all Number Porting related Port Orders
    /// </summary>
    public PortFileType? NumberPortingOrder { get; set; }
}
