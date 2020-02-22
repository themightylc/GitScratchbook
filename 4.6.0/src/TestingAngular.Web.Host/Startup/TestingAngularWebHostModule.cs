using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestingAngular.Configuration;

namespace TestingAngular.Web.Host.Startup
{
    [DependsOn(
       typeof(TestingAngularWebCoreModule))]
    public class TestingAngularWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TestingAngularWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestingAngularWebHostModule).GetAssembly());
        }
    }
}
