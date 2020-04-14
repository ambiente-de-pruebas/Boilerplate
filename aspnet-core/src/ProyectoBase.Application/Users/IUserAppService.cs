using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ProyectoBase.Roles.Dto;
using ProyectoBase.Users.Dto;

namespace ProyectoBase.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
