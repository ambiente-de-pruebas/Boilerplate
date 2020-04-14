using Abp.Authorization;
using ProyectoBase.Authorization.Roles;
using ProyectoBase.Authorization.Users;

namespace ProyectoBase.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
