using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Curnow.biz.MessageCard.Actions
{
    public class ActionBase
    {
        [JsonProperty("@type", NullValueHandling = NullValueHandling.Ignore, Order = 1 )]
        [JsonConverter(typeof(StringEnumConverter))]
        [DefaultValue(null)]
        protected ActionType Type { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        [DefaultValue(null)]
        public string Name { get; set; }
    }
}
