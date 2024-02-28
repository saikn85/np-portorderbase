using NP.WKR.PortOrderBase.Models.Common;

namespace NP.WKR.PortOrderBase.Models
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class GeographicPortConfig
    {
        /// <summary>
        /// Array representing Request Section of the Number Porting Order (NPOR) form
        /// </summary>
        public required CellConfiguration[] RequestConfig { get; set; }

        /// <summary>
        /// Array representing Response section of the Number Porting Order (NPOR) form
        /// </summary>
        public required CellConfiguration[] ResponseConfig { get; set; }
    }
}
