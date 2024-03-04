namespace NP.WKR.PortOrderBase.Models.PortFileActions;

/// <summary>
/// Final Path of the Port Order File(s)
/// </summary>
public sealed class PortFileState
{
    /// <summary>
    /// Path holding, all Port Order Files that were processed successfully.
    /// </summary>
    public string? Processed { get; set; }

    /// <summary>
    /// Path holding, all Port Order Files that need a new round of processing.
    /// </summary>
    public string? Retry { get; set; }
}
