using System.Threading.Tasks;
using ProyectoBase.Configuration.Dto;

namespace ProyectoBase.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
