namespace NP.WKR.PortOrderBase.Models.Common;

/// <summary>
/// Class representing placeholders and cell references for reading and writing data from NPOR Form
/// </summary>
public sealed class CellConfiguration
{
    /// <summary>
    /// Placeholder
    /// </summary>
    public string? CellDetail { get; set; }
    
    /// <summary>
    /// Cell Reference
    /// </summary>
    public string? CellReference { get; set; }
}
