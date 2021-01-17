using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Liz.VueApp.MultiTenancy;

namespace Liz.VueApp.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
