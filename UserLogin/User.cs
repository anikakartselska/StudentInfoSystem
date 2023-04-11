using System;

namespace UserLogin
{
    public class User
    {
        private int userId;
        private String Username;
        private String Password;
        private String FakNum;
        private UserRoles Role;
        private DateTime createdOn;
        public DateTime? activeTo;

        public int UserId
        {
            get => userId;
            set => userId = value;
        }

        public string Username1
        {
            get => Username;
            set => Username = value;
        }

        public string Password1
        {
            get => Password;
            set => Password = value;
        }

        public string FakNum1
        {
            get => FakNum;
            set => FakNum = value;
        }

        public UserRoles Role1
        {
            get => Role;
            set => Role = value;
        }

        public DateTime CreatedOn
        {
            get => createdOn;
            set => createdOn = value;
        }

        public DateTime? ActiveTo
        {
            get => activeTo;
            set => activeTo = value;
        }

        public override string ToString()
        {
            return String.Join(",", Username, Password, FakNum, Role);
        }

        public User(string username, string password, string fakNum, UserRoles role)
        {
            Username = username;
            Password = password;
            FakNum = fakNum;
            Role = role;
        }

        public User()
        {
        }

        public User(string username, string password, string fakNum, UserRoles role, DateTime createdOn,
            DateTime activeTo)
        {
            Username = username;
            Password = password;
            FakNum = fakNum;
            Role = role;
            this.createdOn = createdOn;
            this.activeTo = activeTo;
        }
    }
}