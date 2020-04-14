using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProyectoBase.Configuration;

namespace ProyectoBase.Web.Host.Startup
{
    [DependsOn(
       typeof(ProyectoBaseWebCoreModule))]
    public class ProyectoBaseWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ProyectoBaseWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProyectoBaseWebHostModule).GetAssembly());
        }
    }
}
