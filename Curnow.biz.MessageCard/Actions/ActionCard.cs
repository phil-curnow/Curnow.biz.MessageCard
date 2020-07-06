using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

using Curnow.biz.MessageCard.Inputs;

namespace Curnow.biz.MessageCard.Actions
{
    public class ActionCard : ActionBase
    {
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        [DefaultValue(null)]
        public IEnumerable<InputBase> Inputs { get; set; }

        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        [DefaultValue(null)]
        public IEnumerable<ActionBase> Actions { get; set; }

        public ActionCard() => base.Type = ActionType.ActionCard;

    }
}
