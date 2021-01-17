using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Liz.VueApp.Configuration;
using Liz.VueApp.Web;

namespace Liz.VueApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class VueAppDbContextFactory : IDesignTimeDbContextFactory<VueAppDbContext>
    {
        public VueAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VueAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            VueAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(VueAppConsts.ConnectionStringName));

            return new VueAppDbContext(builder.Options);
        }
    }
}
