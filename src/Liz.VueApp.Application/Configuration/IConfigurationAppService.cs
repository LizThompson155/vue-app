using System.Threading.Tasks;
using Liz.VueApp.Configuration.Dto;

namespace Liz.VueApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
