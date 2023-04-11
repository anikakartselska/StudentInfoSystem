using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
            this.DataContext = new Credentials();
        }

        // private void loginButton_Click(object sender, RoutedEventArgs e)
        // {
        //     String username = usernameTextBox.Text;
        //     String password = passwordTextBox.Text;
        //     LoginValidation loginValidation = new LoginValidation(username, password, MessageBoxShow);
        //     User newUser = new User();
        //     if (loginValidation.ValidateUserInput(ref newUser))
        //     {
        //         MessageBoxShow("Login succesfull!" + newUser.FakNum1);
        //         Window window = new MainWindow(newUser);
        //         window.Show();
        //         Close();
        //        
        //     }
        //  
        // }
        // static void MessageBoxShow(string msg)
        // {
        //     MessageBox.Show("!!! " + msg + " !!!");
        // }
    }
}
