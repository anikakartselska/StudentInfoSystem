using System;
using System.Windows;
using System.Windows.Input;
using UserLogin;

namespace StudentInfoSystem
{
    public class LoginCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            if (parameter == null){ return false;}
           
                var list = parameter as Credentials;
                            var username = list.Username;
                            var password = list.Password;
                            if (username.Equals(String.Empty) 
                                || username.Length < 5
                                || password.Equals(String.Empty) 
                                || password.Length < 5)
                            {
                                return false;
                            }
            
            return true;
        }

        public void Execute(object parameter)
        {
            var list = parameter as Credentials;
            var username = list.Username;
            var password = list.Password;
            // MessageBox.Show("Hello, world!" + " " + username + " " + pass);
            LoginValidation loginValidation = new LoginValidation(username, password, MessageBoxShow);
            User newUser = new User();
            if (loginValidation.ValidateUserInput(ref newUser))
            {
                MessageBoxShow("Login succesfull!" + newUser.FakNum1);
                Window window = new MainWindow(newUser);
                (Application.Current.MainWindow)?.Close();
                window.Show();
            }
        }

        static void MessageBoxShow(string msg)
        {
            MessageBox.Show("!!! " + msg + " !!!");
        }

        public event EventHandler CanExecuteChanged;
        
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}