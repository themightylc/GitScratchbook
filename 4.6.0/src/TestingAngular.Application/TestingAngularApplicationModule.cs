using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestingAngular.Authorization;

namespace TestingAngular
{
    [DependsOn(
        typeof(TestingAngularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TestingAngularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TestingAngularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TestingAngularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
