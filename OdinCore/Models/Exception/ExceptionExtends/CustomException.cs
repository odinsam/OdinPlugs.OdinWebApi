using OdinPlugs.OdinWebApi.OdinCore.Models.Exception;

namespace OdinPlOdinPlugs.OdinWebApiugs.OdinCore.Models.Exception.ExceptionExtends
{
    public class CustomException : OdinException
    {
        public CustomException(string errorCode) : base(errorCode) { }
    }
}