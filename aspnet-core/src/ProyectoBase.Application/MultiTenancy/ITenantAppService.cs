using Abp.Application.Services;
using ProyectoBase.MultiTenancy.Dto;

namespace ProyectoBase.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

