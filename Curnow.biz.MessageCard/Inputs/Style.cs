using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Curnow.biz.MessageCard.Inputs
{
    public enum Style
    {
        [EnumMember(Value = "normal")]
        Normal,

        [EnumMember(Value = "expanded")]
        Expanded
    }
}
