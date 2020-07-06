using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Curnow.biz.MessageCard.Section
{
    public class Fact
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [DefaultValue(null)]
        public string Name { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        [DefaultValue(null)]
        public string Value { get; set; }
    }
}
