using OdinPlugs.OdinWebApi.OdinCore.Models.Exception;

namespace OdinPlugs.OdinWebApi.OdinCore.Models.Exception.ExceptionExtends
{
    public class RequestGuidException : OdinException
    {
        public RequestGuidException(string errorCode) : base(errorCode) { }
    }
}