using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Curnow.biz.MessageCard.Actions
{
    public enum TargetOS
    {
        [EnumMember(Value = "default")]
        Default,

        [EnumMember(Value = "windows")]
        Windows,

        [EnumMember(Value = "iOS")]
        iOS,

        [EnumMember(Value = "android")]
        Android,
    }
}
