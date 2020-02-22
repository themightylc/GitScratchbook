using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TestingAngular.Configuration;
using TestingAngular.Web;

namespace TestingAngular.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TestingAngularDbContextFactory : IDesignTimeDbContextFactory<TestingAngularDbContext>
    {
        public TestingAngularDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TestingAngularDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TestingAngularDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TestingAngularConsts.ConnectionStringName));

            return new TestingAngularDbContext(builder.Options);
        }
    }
}
