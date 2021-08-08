using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using OdinPlugs.OdinWebApi.OdinCore.Models;
using OdinPlugs.OdinWebApi.OdinMvcCore.MvcCore;

namespace OdinPlugs.OdinWebApi.OdinMvcCore.ViewModelValidate
{
    public abstract class AbstractModelValidate : IModelValidate
    {
        public DbContext DB { get; set; }
        public ApiCommentConfig api { get; set; }
        public string developerName { get; set; }
        public string developerEmailAddress { get; set; }

        public AbstractModelValidate(DbContext _db)
        {
            DB = _db;
        }

        public AbstractModelValidate(DbContext _db, ApiCommentConfig _api, string _developerName, string _developerEmailAddress)
        {
            DB = _db;
            this.api = _api;
            this.developerName = _developerName;
            this.developerEmailAddress = _developerEmailAddress;
        }

        public DbSet<T> GetIRepository<T>() where T : class
        {
            return DB.Set<T>();
        }
    }
}