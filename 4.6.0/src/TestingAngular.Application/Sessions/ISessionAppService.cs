using System.Threading.Tasks;
using Abp.Application.Services;
using TestingAngular.Sessions.Dto;

namespace TestingAngular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
