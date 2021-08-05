using System;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EnumTestJsonConvert
{
    /// <summary>
    /// The SMS template for AliCloud.
    /// </summary>
    public class AliCloudChinaSMSTemplate
    {
        /// <summary>
        /// Gets or sets the AliCloud template content.
        /// </summary>
        /// <value>
        /// The template content.
        /// </value>
        [JsonProperty("TemplateContent")]
        public string TemplateContent { get; set; }

        /// <summary>
        /// Gets or sets the BlueCloud template name.
        /// </summary>
        /// <value>
        /// The template name.
        /// </value>
        [JsonProperty("TemplateName")]
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets the AliCloud template type.
        /// </summary>
        /// <value>
        /// The template type.
        /// </value>
        [JsonProperty("TemplateType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AliCloudTemplateType TemplateType { get; set; }

        /// <summary>
        /// Gets or sets the AliCloud template status.
        /// </summary>
        /// <value>
        /// The template type.
        /// </value>
        [JsonProperty("TemplateStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AliCloudTemplateStatus TemplateStatus { get; set; }
    }
}
