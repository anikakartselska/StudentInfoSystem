using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace StudentInfoSystem
{
    public class  Credentials: INotifyPropertyChanged 
    { 
        string _username = ""; 
        string _password = "";
        private string _errorMessage = "";

        private  LoginCommand _loginCommandCode = new LoginCommand();
        
        
        public LoginCommand LoginCommand
        {
            get { return _loginCommandCode;  }
        }
        public Credentials() 
        { 
            MyCredentials = new ObservableCollection<string>();
       
        } 
        public string Username 
        { 
            get { return _username; } 
            set
            { 
                if (_username != value) 
                { 
                    _username = value; 
                    OnPropertyChanged("Username");
                } 
            } 
        } 
        public string Password 
        { 
            get { return _password; } 
            set
            { 
                if (_password != value) 
                { 
                    _password = value; 
                    OnPropertyChanged("Password");
                } 
            } 
        }
    
        public string ErrorMessage 
        { 
            get { return _errorMessage; } 
            set
            { 
                if (_errorMessage != value) 
                { 
                    _errorMessage = value; 
                    OnPropertyChanged("ErrorMessage");
                } 
            } 
        }
        public ObservableCollection<string> MyCredentials { get; private set; } 
        private void OnPropertyChanged(string property) 
        { 
            if (PropertyChanged != null) 
            { 
                PropertyChanged(this, new PropertyChangedEventArgs(property));
                _loginCommandCode.RaiseCanExecuteChanged();
            } 
        } 
        
        public event PropertyChangedEventHandler PropertyChanged; 
    }
}