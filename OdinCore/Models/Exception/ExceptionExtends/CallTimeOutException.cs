using OdinPlugs.OdinWebApi.OdinCore.Models.Exception;

namespace OdinPlugs.OdinWebApi.OdinCore.Models.Exception.ExceptionExtends
{
    public class CallTimeOutException : OdinException
    {
        public CallTimeOutException(string errorCode) : base(errorCode) { }
    }
}