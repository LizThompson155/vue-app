using Abp.Application.Services;
using Liz.VueApp.MultiTenancy.Dto;

namespace Liz.VueApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

