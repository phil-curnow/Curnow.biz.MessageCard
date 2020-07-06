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
    public class HttpPOSTAction : ActionBase
    {
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        [DefaultValue(null)]
        public string Target { get; set; }

        [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        [DefaultValue(null)]
        public IEnumerable<Header> Headers { get; set; }

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        [DefaultValue(null)]
        public string Body { get; set; }

        [JsonProperty("bodyContentType", NullValueHandling = NullValueHandling.Ignore, Order = 6)]
        [JsonConverter(typeof(StringEnumConverter))]
        [DefaultValue(BodyContentType.Json)]
        public BodyContentType BodyContentType { get; set; }

        public HttpPOSTAction() => base.Type = ActionType.HttpPOST;
    }
}
