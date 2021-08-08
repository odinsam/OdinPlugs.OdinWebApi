using Microsoft.EntityFrameworkCore;
using OdinPlugs.OdinEFCore.DBContext;
using OdinPlugs.OdinEFCore.EntityFrameworkExtensions.EFInterface;
using OdinPlugs.OdinWebApi.OdinMvcCore.ServicesCore.ServicesInterface.EntityFrameWork;

namespace OdinPlugs.OdinWebApi.OdinMvcCore.ServicesCore.ServicesAbstract.EntityFrameWork
{
    public abstract class AbstractOdinServiceCore : IOdinServiceCore
    {
        public virtual IBaseRepository<T> GetRepository<T>(DbContext _objectContext) where T : class, new()
        {
            return DBContextFactory.GetRepository<T>(_objectContext);
        }
    }
}