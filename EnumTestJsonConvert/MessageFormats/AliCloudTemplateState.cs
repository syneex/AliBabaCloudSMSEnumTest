using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace EnumTestJsonConvert
{
    /// <summary>
    /// The AliCloud Template Status enum.
    /// </summary>
    public enum AliCloudTemplateStatus
    {
        /// <summary>
        /// [0] The Under Review Status.
        /// </summary>
        Review = 0,

        /// <summary>
        /// [1] The Approved Status.
        /// </summary>
        Approved = 1,

        /// <summary>
        /// [2] The Blocked Status.
        /// </summary>
        Blocked = 2,
    }
}
