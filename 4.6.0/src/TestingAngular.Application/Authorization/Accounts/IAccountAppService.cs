using System.Threading.Tasks;
using Abp.Application.Services;
using TestingAngular.Authorization.Accounts.Dto;

namespace TestingAngular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
