using OdinPlugs.OdinWebApi.OdinCore.Models.Exception;

namespace OdinPlugs.OdinWebApi.OdinCore.Models.Exception.ExceptionExtends
{
    public class ServiceException : OdinException
    {
        public ServiceException(string errorCode) : base(errorCode) { }
    }
}