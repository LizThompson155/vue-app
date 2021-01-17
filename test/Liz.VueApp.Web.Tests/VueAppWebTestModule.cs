using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Liz.VueApp.EntityFrameworkCore;
using Liz.VueApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Liz.VueApp.Web.Tests
{
    [DependsOn(
        typeof(VueAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class VueAppWebTestModule : AbpModule
    {
        public VueAppWebTestModule(VueAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VueAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(VueAppWebMvcModule).Assembly);
        }
    }
}