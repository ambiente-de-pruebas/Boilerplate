using System.Threading.Tasks;
using Abp.Application.Services;
using ProyectoBase.Authorization.Accounts.Dto;

namespace ProyectoBase.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
