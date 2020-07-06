using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Curnow.biz.MessageCard.Actions
{
    public enum BodyContentType
    {
        [EnumMember(Value = "application/json")]
        Json,
        [EnumMember(Value = "application/x-www-form-urlencoded")]
        FormUrlEncoded
    }
}
