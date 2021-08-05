using System;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EnumTestJsonConvert
{
    /// <summary>
    /// The SMS template for AliCloud.
    /// </summary>
    public class AliCloudChinaSMSTemplateInput : AliCloudChinaSMSTemplate
    {
        /// <summary>
        /// Gets or sets the AliCloud template remark info.
        /// </summary>
        /// <value>
        /// The remark.
        /// </value>
        [JsonProperty("Remark")]
        public string Remark { get; set; }
    }
}
