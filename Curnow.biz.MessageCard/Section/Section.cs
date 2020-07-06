using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

using Curnow.biz.MessageCard.Actions;

namespace Curnow.biz.MessageCard.Section
{
    public class Section
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        [DefaultValue(null)]
        public string Title { get; set; }

        [JsonProperty("startGroup", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        [DefaultValue(false)]
        public bool IsStartGroup { get; set; }

        [JsonProperty("activityImage", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        [DefaultValue(null)]
        public string ActivityImage { get; set; }

        [JsonProperty("activityTitle", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        [DefaultValue(null)]
        public string ActivityTitle { get; set; }

        [JsonProperty("activitySubtitle", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        [DefaultValue(null)]
        public string ActivitySubtitle { get; set; }

        [JsonProperty("activityText", NullValueHandling = NullValueHandling.Ignore, Order = 6)]
        [DefaultValue(null)]
        public string ActivityText { get; set; }

        [JsonProperty("heroImage", NullValueHandling = NullValueHandling.Ignore, Order = 7)]
        [DefaultValue(null)]
        public Image HeroImage { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore, Order = 8)]
        [DefaultValue(null)]
        public string Text { get; set; }

        [JsonProperty("facts", NullValueHandling = NullValueHandling.Ignore, Order = 9)]
        [DefaultValue(null)]
        public IEnumerable<Fact> Facts { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore, Order = 10)]
        [DefaultValue(null)]
        public IEnumerable<Image> Images { get; set; }

        [JsonProperty("potentialAction", NullValueHandling = NullValueHandling.Ignore, Order = 11)]
        [DefaultValue(null)]
        public IEnumerable<ActionBase> Actions { get; set; }
    }
}
