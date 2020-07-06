using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Curnow.biz.MessageCard.Inputs
{
    public class DateInput : InputBase
    {
        [JsonProperty("includeTime", NullValueHandling = NullValueHandling.Ignore, Order = 6)]
        [DefaultValue(null)]
        public bool IncludeTime { get; set; }
        public DateInput() => base.Type = InputType.DateInput;
    }
}
