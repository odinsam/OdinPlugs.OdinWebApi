using System.ComponentModel;

namespace OdinPlugs.OdinWebApi.OdinBasicDataType.OdinEnum
{
    public enum EnumContentType
    {
        [Description("application/json 格式")]
        applicationJson,

        [Description(" form-data 格式")]
        formData
    }
}
