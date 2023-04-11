using System;

namespace UserLogin
{
    public class LoginValidation
    {
        private static UserRoles currentUserRole;
        private static string currentUsername;
        private String username;
        private String password;
        private String errorMessage;

        public delegate void ActionOnError(string errorMsg);

        private ActionOnError ErrorAction;

        public LoginValidation(string username, string password, ActionOnError errorAction)
        {
            this.username = username;
            this.password = password;
            ErrorAction = errorAction;
        }

        public static UserRoles CurrentUserRole
        {
            get => currentUserRole;
            private set => currentUserRole = value;
        }

        public static string CurrentUsername
        {
            get => currentUsername;
            set => currentUsername = value;
        }

        public bool ValidateUserInput(ref User user)
        {
            

            user = UserData.IsUserPassCorrect(username, password);
            if (user == null)
            {
                errorMessage = "User doesn't exist!";
                ErrorAction(errorMessage);
                return false;
            }

            currentUsername = user.Username1;
            currentUserRole = user.Role1;
            Logger.LogActivity("Successful login");
            return true;
        }

        // public bool ValidateUserInput(User user)
        // {
        //     user.Username1 = UserData.TestUser1.Username1;
        //     user.Password1 = UserData.TestUser1.Password1;
        //     user.FakNum1 = UserData.TestUser1.FakNum1;
        //     user.Role1 = UserData.TestUser1.Role1;
        //     currentUserRole = user.Role1;
        //     return true;
        // }
    }
}