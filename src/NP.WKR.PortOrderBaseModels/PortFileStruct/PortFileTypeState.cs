namespace NP.WKR.PortOrderBase.Models.PortFileActions;

/// <summary>
/// Path repesenting type of Port Order 
/// </summary>
public sealed class PortFileTypeState
{
    public PortFileState? Received { get; set; }
    public PortFileState? Sent { get; set;}
}
