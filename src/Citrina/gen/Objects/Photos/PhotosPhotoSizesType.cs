using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Size type.
    /// </summary>
    public enum PhotosPhotoSizesType
    {
        [EnumMember(Value = "s")]
        S,
        [EnumMember(Value = "m")]
        M,
        [EnumMember(Value = "x")]
        X,
        [EnumMember(Value = "o")]
        O,
        [EnumMember(Value = "p")]
        P,
        [EnumMember(Value = "q")]
        Q,
        [EnumMember(Value = "r")]
        R,
        [EnumMember(Value = "y")]
        Y,
        [EnumMember(Value = "z")]
        Z,
        [EnumMember(Value = "w")]
        W,
    }
}
