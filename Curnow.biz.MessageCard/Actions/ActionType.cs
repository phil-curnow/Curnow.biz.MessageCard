using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Curnow.biz.MessageCard.Actions
{
    public enum ActionType
    {
        [EnumMember(Value="OpenUri")]
        OpenUri,
        [EnumMember(Value = "HttpPOST")]
        HttpPOST,
        [EnumMember(Value = "ActionCard")]
        ActionCard,
        [EnumMember(Value = "InvokeAddInCommand")]
        InvokeAddInCommand
    }
}
