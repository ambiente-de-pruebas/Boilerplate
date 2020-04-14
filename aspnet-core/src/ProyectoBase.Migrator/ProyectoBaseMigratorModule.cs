using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProyectoBase.Configuration;
using ProyectoBase.EntityFrameworkCore;
using ProyectoBase.Migrator.DependencyInjection;

namespace ProyectoBase.Migrator
{
    [DependsOn(typeof(ProyectoBaseEntityFrameworkModule))]
    public class ProyectoBaseMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ProyectoBaseMigratorModule(ProyectoBaseEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ProyectoBaseMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ProyectoBaseConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProyectoBaseMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
