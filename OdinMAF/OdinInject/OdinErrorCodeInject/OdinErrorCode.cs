using OdinPlugs.OdinInject.InjectCore;
using OdinPlugs.OdinInject.InjectPlugs.OdinCacheManagerInject;
using OdinPlugs.OdinModels.ErrorCode;

namespace OdinPlugs.OdinWebApi.OdinMAF.OdinInject.OdinErrorCodeInject
{
    public class OdinErrorCode : IOdinErrorCode
    {
        private readonly IOdinCacheManager odinCacheManager;

        public OdinErrorCode()
        {
            this.odinCacheManager = OdinInjectCore.GetService<IOdinCacheManager>();
        }
        public ErrorCode_Model GetErrorModel(string code)
        {
            return this.odinCacheManager.Get<ErrorCode_Model>(code);
        }
    }
}