using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Liz.VueApp.EntityFrameworkCore
{
    public static class VueAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VueAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VueAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
