using System.Threading.Tasks;
using Abp.Application.Services;
using ProyectoBase.Sessions.Dto;

namespace ProyectoBase.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
