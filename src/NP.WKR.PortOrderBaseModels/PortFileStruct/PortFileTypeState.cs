namespace NP.WKR.PortOrderBase.Models.PortFileActions;

/// <summary>
/// Path repesenting type of Port Order Action
/// </summary>
public sealed class PortFileTypeState
{
    /// <summary>
    /// Path for all Port Order Received
    /// </summary>
    public PortFileState? Received { get; set; }
    
    /// <summary>
    /// Path for all Port Order Sent
    /// </summary>
    public PortFileState? Sent { get; set;}
}
