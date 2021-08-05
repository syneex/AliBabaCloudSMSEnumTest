using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EnumTestJsonConvert
{
    /// <summary>
    /// The AliCloud Template Type enum.
    /// </summary>
    public enum AliCloudTemplateType
    {
        /// <summary>
        /// [0] The Verification Template Type.
        /// </summary>
        Verification,

        /// <summary>
        /// [1] The Notification Template Type.
        /// </summary>
        Notification,

        /// <summary>
        /// [2] The Promotion Template Type.
        /// </summary>
        Promotion,
    }
}
