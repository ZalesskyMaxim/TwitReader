using System;
using TwitReader.ViewModels.Base;

namespace TwitReader.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged(nameof(UserName));
                }
            }
        }


		private string _password;
        public string Password
        {
            get { return _password; }
            set 
            {
                if (_password != value) {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public LoginViewModel()
        {
        }
    }
}
