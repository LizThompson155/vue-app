using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Liz.VueApp.Authorization;

namespace Liz.VueApp
{
    [DependsOn(
        typeof(VueAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VueAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VueAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VueAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
