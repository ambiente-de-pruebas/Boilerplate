using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ProyectoBase.Controllers
{
    public abstract class ProyectoBaseControllerBase: AbpController
    {
        protected ProyectoBaseControllerBase()
        {
            LocalizationSourceName = ProyectoBaseConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
