using System.Threading.Tasks;
using Abp.Application.Services;
using Liz.VueApp.Sessions.Dto;

namespace Liz.VueApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
