using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Liz.VueApp.Controllers
{
    public abstract class VueAppControllerBase: AbpController
    {
        protected VueAppControllerBase()
        {
            LocalizationSourceName = VueAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
