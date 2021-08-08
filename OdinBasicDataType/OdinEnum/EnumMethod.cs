using System.ComponentModel;

namespace OdinPlugs.OdinWebApi.OdinBasicDataType.OdinEnum
{
    public enum EnumMethod
    {
        [Description("HttpGet")]
        Get,

        [Description("HttpPost")]
        Post,

        [Description("HttpPut")]
        Put,

        [Description("HttpDelete")]
        Delete
    }
}
