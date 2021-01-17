using System.Threading.Tasks;
using Abp.Application.Services;
using Liz.VueApp.Authorization.Accounts.Dto;

namespace Liz.VueApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
