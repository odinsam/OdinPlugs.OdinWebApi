using OdinPlugs.OdinWebApi.OdinCore.Models.Exception;

namespace OdinPlugs.OdinWebApi.OdinCore.Models.Exception.ExceptionExtends
{
    public class ParamSignException : OdinException
    {
        public ParamSignException(string errorCode) : base(errorCode) { }
    }
}