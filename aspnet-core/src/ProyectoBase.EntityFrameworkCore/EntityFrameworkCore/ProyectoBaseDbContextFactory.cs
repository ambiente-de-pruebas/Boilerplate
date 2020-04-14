using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ProyectoBase.Configuration;
using ProyectoBase.Web;

namespace ProyectoBase.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProyectoBaseDbContextFactory : IDesignTimeDbContextFactory<ProyectoBaseDbContext>
    {
        public ProyectoBaseDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProyectoBaseDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProyectoBaseDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProyectoBaseConsts.ConnectionStringName));

            return new ProyectoBaseDbContext(builder.Options);
        }
    }
}
