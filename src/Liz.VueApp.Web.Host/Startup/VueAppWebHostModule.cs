using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Liz.VueApp.Configuration;

namespace Liz.VueApp.Web.Host.Startup
{
    [DependsOn(
       typeof(VueAppWebCoreModule))]
    public class VueAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VueAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VueAppWebHostModule).GetAssembly());
        }
    }
}
