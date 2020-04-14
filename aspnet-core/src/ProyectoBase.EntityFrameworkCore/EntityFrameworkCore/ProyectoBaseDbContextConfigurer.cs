using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ProyectoBase.EntityFrameworkCore
{
    public static class ProyectoBaseDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProyectoBaseDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProyectoBaseDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
