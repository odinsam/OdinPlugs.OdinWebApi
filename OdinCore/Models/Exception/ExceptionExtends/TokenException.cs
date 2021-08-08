using OdinPlugs.OdinWebApi.OdinCore.Models.Exception;

namespace OdinPlugs.OdinWebApi.OdinCore.Models.Exception.ExceptionExtends
{
    public class TokenException : OdinException
    {
        public TokenException(string errorCode) : base(errorCode) { }
    }
}