using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Curnow.biz.MessageCard.Actions
{
    public class OpenUriAction : ActionBase
    {
        [JsonProperty("targets", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        [DefaultValue(null)]
        public IEnumerable<Target> Targets { get; set; }

        public OpenUriAction() => base.Type = ActionType.OpenUri;
    }
}
