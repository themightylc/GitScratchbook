using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TestingAngular.Controllers
{
    public abstract class TestingAngularControllerBase: AbpController
    {
        protected TestingAngularControllerBase()
        {
            LocalizationSourceName = TestingAngularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
