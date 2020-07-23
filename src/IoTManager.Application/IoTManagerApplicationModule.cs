using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IoTManager.Authorization;
//注入AutoMapper规则需要引用的库 20200720
using IoTManager.Roles.Dto;

namespace IoTManager
{
    [DependsOn(
        typeof(IoTManagerCoreModule),
        typeof(AbpAutoMapperModule))]
    public class IoTManagerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //2020/07/20注入AutoMapper的映射规则
            Configuration.Modules.AbpAutoMapper().Configurators.Add(item: config =>
            {
                config.AddProfile<RoleMapProfile>();
            });
            Configuration.Authorization.Providers.Add<IoTManagerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IoTManagerApplicationModule).GetAssembly());
        }
    }
}