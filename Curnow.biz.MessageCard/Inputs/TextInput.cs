using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Curnow.biz.MessageCard.Inputs
{
    public class TextInput : InputBase
    {
        [JsonProperty("isMultiline", NullValueHandling = NullValueHandling.Ignore, Order = 6)]
        [DefaultValue(null)]
        public bool IsMultiLine { get; set; }

        [JsonProperty("MaxLength", NullValueHandling = NullValueHandling.Ignore, Order = 7)]
        [DefaultValue(null)]
        public int? MaxLength { get; set; }

        public TextInput() => base.Type = InputType.TextInput;
    }
}
