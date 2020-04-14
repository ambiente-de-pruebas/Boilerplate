using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProyectoBase.Authorization;

namespace ProyectoBase
{
    [DependsOn(
        typeof(ProyectoBaseCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProyectoBaseApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProyectoBaseAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProyectoBaseApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
