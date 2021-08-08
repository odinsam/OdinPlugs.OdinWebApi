using OdinPlugs.OdinWebApi.OdinCore.Models.Exception;

namespace OdinPlugs.OdinWebApi.OdinCore.Models.Exception.ExceptionExtends
{
    public class AllowIpException : OdinException
    {
        public AllowIpException(string errorCode) : base(errorCode) { }
    }
}