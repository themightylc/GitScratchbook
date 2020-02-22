using Abp.Authorization;
using TestingAngular.Authorization.Roles;
using TestingAngular.Authorization.Users;

namespace TestingAngular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
