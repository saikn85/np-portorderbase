namespace NP.WKR.PortOrderBase.Models.Common;

/// <summary>
/// Enumeration for all Configurations
/// </summary>
public enum ConfigType : ushort
{
    #region Base Config

    /// <summary>
    /// Flag for Root Working Directory
    /// </summary>
    PortOrderBaseWorkDir = 0,

    #endregion

    #region Port Config

    /// <summary>
    /// Flag for all Geographic Ports
    /// </summary>
    Geographic = 500,

    /// <summary>
    /// Flag for all Non-Geographic Ports
    /// </summary>
    NonGeographic = 501,

    #endregion

    #region Activation Config

    /// <summary>
    /// Flag for all Activations that have XLS or XLSX as file extension
    /// </summary>
    ActivationExcel = 1000,

    /// <summary>
    /// Flag for all Activations that have csv as file extension
    /// </summary>
    ActivationCsv = 1001

    #endregion
}