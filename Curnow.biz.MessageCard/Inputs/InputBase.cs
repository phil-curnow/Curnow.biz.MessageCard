using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Curnow.biz.MessageCard.Inputs
{
    public class InputBase
    {

        [JsonProperty("@type", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        [JsonConverter(typeof(StringEnumConverter))]
        protected InputType Type { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        [DefaultValue(null)]
        public string Id { get; set; }

        [JsonProperty("isRequired", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        [DefaultValue(false)]
        public bool IsRequired { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        [DefaultValue(null)]
        public string Title { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        [DefaultValue(null)]
        public string Value { get; set; }
    }
}
