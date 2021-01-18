using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Liz.VueApp.Authorization.Roles;
using Liz.VueApp.Authorization.Users;
using Liz.VueApp.MultiTenancy;
using Liz.VueApp.Books;

namespace Liz.VueApp.EntityFrameworkCore
{
    public class VueAppDbContext : AbpZeroDbContext<Tenant, Role, User, VueAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Book> Books { get; set; }

        public VueAppDbContext(DbContextOptions<VueAppDbContext> options)
            : base(options)
        { }
    }
}

