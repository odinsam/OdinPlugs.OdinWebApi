using Microsoft.EntityFrameworkCore;
using OdinPlugs.OdinEFCore.EntityFrameworkExtensions.EFInterface;
using OdinPlugs.OdinInject.InjectInterface;

namespace OdinPlugs.OdinWebApi.OdinMvcCore.ServicesCore.ServicesInterface.EntityFrameWork
{
    public interface IOdinServiceCore : IService, IAutoInject
    {
        IBaseRepository<T> GetRepository<T>(DbContext _objectContext) where T : class, new();
    }
}