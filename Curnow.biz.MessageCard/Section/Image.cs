using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Curnow.biz.MessageCard.Section
{
    public class Image
    {
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        [DefaultValue(null)]
        public string Uri { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        [DefaultValue(null)]
        public string Title { get; set; }
    }
}
