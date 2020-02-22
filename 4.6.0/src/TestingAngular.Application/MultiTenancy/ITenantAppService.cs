using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TestingAngular.MultiTenancy.Dto;

namespace TestingAngular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

