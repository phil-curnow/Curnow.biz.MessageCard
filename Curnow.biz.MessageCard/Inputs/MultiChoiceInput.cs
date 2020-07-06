using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Curnow.biz.MessageCard.Inputs
{
    public class MultiChoiceInput : InputBase
    {
        [JsonProperty("choices", NullValueHandling = NullValueHandling.Ignore, Order = 6)]
        [DefaultValue(null)]
        public IEnumerable<Choice> Choices { get; set; }

        [JsonProperty("isMultiSelect", NullValueHandling = NullValueHandling.Ignore, Order = 7)]
        [DefaultValue(false)]
        public bool IsMultiSelect { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore, Order = 8)]
        [JsonConverter(typeof(StringEnumConverter))]
        [DefaultValue(Style.Normal)]
        public Style Style { get; set; }
        public MultiChoiceInput() => base.Type = InputType.MultichoiceInput;
    }
}
