using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Curnow.biz.MessageCard.Actions
{
    public class InvokeAddInCommandAction : ActionBase
    {
        [JsonProperty("addInId", NullValueHandling = NullValueHandling.Ignore, Order=3)]
        public Guid AddInId { get; set; }

        [JsonProperty("desktopCommandId", NullValueHandling = NullValueHandling.Ignore, Order=4)]
        [DefaultValue(null)]
        public string DesktopCommandId { get; set; }

        [JsonProperty("initializationContext", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        [DefaultValue(null)]
        public object InitializationContext { get; set; }
        public InvokeAddInCommandAction() => base.Type = ActionType.InvokeAddInCommand;
    }
}
