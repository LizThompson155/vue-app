using Abp.MultiTenancy;
using Liz.VueApp.Authorization.Users;

namespace Liz.VueApp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
