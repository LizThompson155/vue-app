using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Liz.VueApp.Authorization.Roles;
using Liz.VueApp.Authorization.Users;
using Liz.VueApp.MultiTenancy;

namespace Liz.VueApp.EntityFrameworkCore
{
    public class VueAppDbContext : AbpZeroDbContext<Tenant, Role, User, VueAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public VueAppDbContext(DbContextOptions<VueAppDbContext> options)
            : base(options)
        {
        }
    }
}
