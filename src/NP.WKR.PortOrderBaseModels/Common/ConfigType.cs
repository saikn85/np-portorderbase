namespace NP.WKR.PortOrderBase.Models.Common;

/// <summary>
/// Tyoe of Port Orders
/// </summary>
public enum ConfigType
{
    /// <summary>
    /// Flag for all Geographic Ports
    /// </summary>
    Geographic,

    /// <summary>
    /// Flag for all Non-Geographic Ports
    /// </summary>
    NonGeographic,

    /// <summary>
    /// Flag for all Activations that have XLS or XLSX as file extension
    /// </summary>
    ActivationExcel,

    /// <summary>
    /// Flag for all Activations that have csv as file extension
    /// </summary>
    ActivationCsv
}
