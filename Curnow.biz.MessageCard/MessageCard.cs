using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

using Curnow.biz.MessageCard.Actions;
using Curnow.biz.MessageCard.Section;


namespace Curnow.biz.MessageCard
{
    public class MessageCard
    {
        [JsonProperty("@type", Order = 1)]
        public string Type { get => "MessageCard"; }

        [JsonProperty("@context", Order = 2)]
        public string Context { get => "http://schema.org/extensions"; }

        [JsonProperty("correlationId", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        [DefaultValue(null)]
        public Guid? CorrelationId { get; set; }

        [JsonProperty("expectedActors", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        [DefaultValue(null)]
        public IEnumerable<string> ExpectedActors { get; set; }

        [JsonProperty("originator", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        [DefaultValue(null)]
        public string Originator { get; set; }

        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore, Order = 6)]
        [DefaultValue(null)]
        public string Summary { get; set; }

        [JsonProperty("themeColor", NullValueHandling = NullValueHandling.Ignore, Order = 7)]
        [DefaultValue(null)]
        public string ThemeColor { get; set; }

        [JsonProperty("hideOriginalBody", NullValueHandling = NullValueHandling.Ignore, Order = 8)]
        [DefaultValue(null)]
        public bool? HideOriginalBody { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore, Order = 9)]
        public string Title { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore, Order = 10)]
        public string Text { get; set; }

        [JsonProperty("sections", NullValueHandling = NullValueHandling.Ignore, Order = 11)]
        public IEnumerable<Section.Section> Sections { get; set; }

        [JsonProperty("potentialAction", NullValueHandling = NullValueHandling.Ignore, Order = 12)]
        public IEnumerable<ActionBase> Actions { get; set; }


        public string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
