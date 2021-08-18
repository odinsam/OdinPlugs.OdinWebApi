using OdinPlugs.OdinInject.InjectInterface;
using OdinPlugs.OdinModels.ErrorCode;

namespace OdinPlugs.OdinWebApi.OdinMAF.OdinInject.OdinErrorCodeInject
{
    public interface IOdinErrorCode : IAutoInject
    {
        /// <summary>
        /// Get errorCode
        /// </summary>
        /// <param name="code">errorCode - string</param>
        /// <returns>ErrorCode_Model</returns>
        ErrorCode_Model GetErrorModel(string code);
    }
}