using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogin
{
    public static class UserData
    {
        private static User TestUser;
        private static List<User> _testUser;

        public static List<User> TestUser1
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set => _testUser = value;
        }

        private static void ResetTestUserData()
        {
            if (_testUser == null)
            {
                _testUser = new List<User>();
                _testUser.Add(
                    new User("anika", "parola", "121220100", UserRoles.ADMIN, DateTime.Now, DateTime.MaxValue));
                _testUser.Add(new User("anika1", "parola1", "1111111111", UserRoles.ADMIN, DateTime.Now,
                    DateTime.MaxValue));
                _testUser.Add(new User("anika2", "parola2", "2222222222", UserRoles.ADMIN, DateTime.Now,
                    DateTime.MaxValue));
            }
        }

        public static User IsUserPassCorrect(string username, string password)
        {
            // foreach (var user in _testUser)
            // {
            //     if (user.Username1.Equals(username) && user.Password1.Equals(password))
            //     {
            //         return user;
            //     }
            // }
            // return null;
            UserContext context = new UserContext();
            List<User> Users = (from user in context.Users
                where user.Username1.Equals(username) && user.Password1.Equals(password)
                select user).ToList();

            if (Users.Count > 0)
            {
                return Users.First();
            }
            else
            {
                return null;
            }
        }

        public static void SetUserActiveTo(string username, DateTime activeTo)
        {
            UserContext context = new UserContext();
            List<User> Users = (from user in context.Users
                where user.Username1.Equals(username)
                select user).ToList();

            if (Users.Count > 0)
            {
                Users.First().activeTo = activeTo;
                Logger.LogActivity("Change activity of" + username);
            }
        }

        public static void AssignUserRole(string username, UserRoles role)
        {
            UserContext context = new UserContext();
            List<User> Users = (from user in context.Users
                where user.Username1.Equals(username)
                select user).ToList();

            if (Users.Count > 0)
            {
                Users.First().Role1 = role;
                Logger.LogActivity("Change user role of " + username);
            }
        }
    }
}