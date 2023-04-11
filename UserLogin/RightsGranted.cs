using System.Collections.Generic;

namespace UserLogin
{
    public static class RightsGranted
    {
        public static Dictionary<UserRoles, List<RoleRight>> RoleToRightsMap =
            new Dictionary<UserRoles, List<RoleRight>>()
            {
                { UserRoles.ANONYMOUS, new List<RoleRight>() { RoleRight.VIEW_ALL_USERS } },
                {
                    UserRoles.ADMIN,
                    new List<RoleRight>() { RoleRight.VIEW_LOGS, RoleRight.EDIT_USER, RoleRight.VIEW_ALL_USERS }
                },
                { UserRoles.INSPECTOR, new List<RoleRight>() { RoleRight.VIEW_LOGS, RoleRight.VIEW_ALL_USERS } },
                { UserRoles.PROFESSOR, new List<RoleRight>() { RoleRight.VIEW_LOGS, RoleRight.VIEW_ALL_USERS } },
                { UserRoles.STUDENT, new List<RoleRight>() { RoleRight.VIEW_LOGS } }
            };
    }
}