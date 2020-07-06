using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Curnow.biz.MessageCard.Inputs
{
    public enum InputType
    {
        [EnumMember(Value = "TextInput")]
        TextInput,
        [EnumMember(Value = "DateInput")]
        DateInput,
        [EnumMember(Value = "MultichoiceInput")]
        MultichoiceInput
    }
}
