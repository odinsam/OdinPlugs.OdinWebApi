using OdinPlugs.OdinWebApi.OdinCore.Models.Exception;

namespace OdinPlugs.OdinWebApi.OdinCore.Models.Exception.ExceptionExtends
{
    public class ErrorCodeListIndexException : OdinException
    {
        public ErrorCodeListIndexException(string errorCode) : base(errorCode) { }
    }
}