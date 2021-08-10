using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
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
        Verification = 0,

        /// <summary>
        /// [1] The Notification Template Type.
        /// </summary>
        Notification = 1,

        /// <summary>
        /// [2] The Promotion Template Type.
        /// </summary>
        Promotion = 2,
    }
}
