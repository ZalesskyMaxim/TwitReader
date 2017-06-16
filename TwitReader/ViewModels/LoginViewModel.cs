using System;
using System.Windows.Input;
using TwitReader.ViewModels.Base;
using Xamarin.Auth;
using Xamarin.Forms;

namespace TwitReader.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public ICommand LoginToTwitterCommand { get; private set; }
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
            LoginToTwitterCommand = new Command(ExecuteLoginToTwitterCommand);
        }

        Account loggedInAccount;
        private bool _isAuhtenticated;
        private void ExecuteLoginToTwitterCommand()
        {
			//var auth = new OAuth1Authenticator(consumerKey: AppConfig.ConsumerKey,
			//consumerSecret: AppConfig.ConsumerSecretKey,
			//requestTokenUrl: AppConfig.RequestTokenUrl,
			//authorizeUrl: AppConfig.AuthorizeUrl,
			//accessTokenUrl: AppConfig.AccessTokenUrl,
			//callbackUrl: AppConfig.CallbackUrl
			//);

            var auth = new OAuth2Authenticator()(
					consumerKey: "C9iv9Cwq0lrH02qdOk5BTtNYv",
				 consumerSecret: "u4PRH3RSxsSYozWMGPbS809MbZmznxr7k493fW0vjxeJ6q18V9",
				  requestTokenUrl: new Uri("https://api.twitter.com/oauth/request_token"),
				   authorizeUrl: new Uri("https://api.twitter.com/oauth/authorize"),
				  accessTokenUrl: new Uri("https://api.twitter.com/oauth/access_token"),
				 callbackUrl: new Uri("https://mobile.twitter.com/"));


			auth.Completed += (s, eventArgs) =>
            {
                _isAuhtenticated = eventArgs.IsAuthenticated;
                if (_isAuhtenticated)
	            {
					//btnPost.Enabled = true;
					//btnSearch.Enabled = true;
					//btnTimeLine.Enabled = true;
					loggedInAccount = eventArgs.Account;
					//save the account data for a later session, according to Twitter docs, this doesn't expire
					AccountStore.Create().Save(loggedInAccount, "Twitter");
					//GetTwitterData();
					//DismissViewController(true, null);

			    }
			};

			//PresentViewController(ui, true, null);

            DependencyService.Get<ITwitterLoginUi>().DisplayUI(auth);
        }
    }
}
