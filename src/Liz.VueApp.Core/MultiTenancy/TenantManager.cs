using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Liz.VueApp.Authorization.Users;
using Liz.VueApp.Editions;

namespace Liz.VueApp.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
