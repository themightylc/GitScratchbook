using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TestingAngular.Configuration.Dto;

namespace TestingAngular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestingAngularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
