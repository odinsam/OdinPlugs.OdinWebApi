using Mapster;
using Microsoft.Extensions.DependencyInjection;
using OdinPlugs.OdinInject.InjectPlugs;
using OdinPlugs.OdinModels.ConfigModel;
using OdinPlugs.OdinModels.ConfigModel.RabbitMQ;
using OdinPlugs.OdinModels.ConfigModel.RedisModels;
using OdinPlugs.SnowFlake.Inject;

namespace OdinPlugs.OdinWebApi.OdinMAF.OdinInject
{
    public static class OdinInjectExtensions
    {
        /// <summary>
        /// 注入常用的接口 - SnowFlake、MongoDb、Redis、CacheManager、CapEventBus、Canal、CapInject
        /// </summary>
        /// <param name="services"></param>
        /// <param name="_Options"></param>
        /// <returns></returns>
        public static IServiceCollection AddOdinInject(this IServiceCollection services, ConfigOptions _Options)
        {
            services
                .AddSingletonSnowFlake(_Options.FrameworkConfig.SnowFlake.DataCenterId, _Options.FrameworkConfig.SnowFlake.WorkerId)
                .AddOdinTransientMongoDb(
                    opt => { opt.ConnectionString = _Options.MongoDb.MongoConnection; opt.DbName = _Options.MongoDb.Database; })
                .AddOdinTransientRedis(
                    opt => { opt.ConnectionString = _Options.Redis.ConnectionStrings; })
                .AddOdinTransientCacheManager(
                    opt =>
                    {
                        opt.OptCm = _Options.CacheManager.Adapt<OdinPlugs.OdinInject.Models.CacheManagerModels.CacheManagerModel>();
                        opt.OptRedis = _Options.Redis;
                    })
                .AddOdinSingletonCapEventBus()
                .AddOdinSingletonCanal()
                .AddOdinCapInject(opt =>
                {
                    opt.MysqlConnectionString = _Options.DbEntity.ConnectionString;
                    opt.RabbitmqOptions = _Options.RabbitMQ;
                });
            return services;
        }
    }
}