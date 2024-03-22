namespace NP.WKR.PortOrderBase.Models.Common;

public enum ConfigTypeError: ushort
{
    #region Base Config

    /// <summary>
    /// Flag for Root Working Directory
    /// </summary>
    BASE_WORK_DIR_ERROR,

    #endregion

    #region Port Config - Geographic

    /// <summary>
    /// Flag for all Geographic Ports
    /// </summary>
    GEO_PORT_FILE_ERROR,

    /// <summary>
    /// Flag for all Geographic Port Configuration
    /// </summary>
    GEO_CONFIG_ERROR,

    #endregion
}
