using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ProyectoBase.Configuration.Dto;

namespace ProyectoBase.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProyectoBaseAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
