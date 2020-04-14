using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProyectoBase.Authorization.Roles;
using ProyectoBase.Authorization.Users;
using ProyectoBase.MultiTenancy;

namespace ProyectoBase.EntityFrameworkCore
{
    public class ProyectoBaseDbContext : AbpZeroDbContext<Tenant, Role, User, ProyectoBaseDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ProyectoBaseDbContext(DbContextOptions<ProyectoBaseDbContext> options)
            : base(options)
        {
        }
    }
}
