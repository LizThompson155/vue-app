using Abp.Authorization;
using Liz.VueApp.Authorization.Roles;
using Liz.VueApp.Authorization.Users;

namespace Liz.VueApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
