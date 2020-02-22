using System.Threading.Tasks;
using TestingAngular.Configuration.Dto;

namespace TestingAngular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
