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
    BaseWorkDirectory = 0,

    #endregion

    #region Activation Config

    Activations = 1000,

    /// <summary>
    /// Flag for all Activations that have XLS or XLSX as file extension
    /// </summary>
    ActTypeExcel = 1001,

    /// <summary>
    /// Flag for all Activations that have csv as file extension
    /// </summary>
    ActTypeCsv = 1002,

    #endregion

    #region Port Config - Geographic

    /// <summary>
    /// Flag for all Geographic Ports
    /// </summary>
    GeoPorts = 2000,

    /// <summary>
    /// Flag for all Geographic Port Configuration
    /// </summary>
    GeoConfig = 2001,

    #endregion

    #region Port Config - Non-Geographic

    /// <summary>
    /// Flag for all Non-Geographic Ports
    /// </summary>
    NonGeographic = 3000,

    #endregion
}