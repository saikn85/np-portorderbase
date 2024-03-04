using NP.WKR.PortOrderBase.Models.PortFileStruct;

namespace NP.WKR.PortOrderBase.Models;

public sealed class PortFile
{
    public PortFileType? Activation { get; set; }
    public PortFileType? NumberPortingOrder { get; set; }
}
