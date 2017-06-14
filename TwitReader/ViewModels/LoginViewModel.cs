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
        private void ExecuteLoginToTwitterCommand()
        {
            var auth = new OAuth1Authenticator(consumerKey: AppConfig.ConsumerKey,
                                               consumerSecret: AppConfig.ConsumerSecretKey,
                                               requestTokenUrl: AppConfig.RequestTokenUrl,
                                               authorizeUrl: AppConfig.AuthorizeUrl,
                                               accessTokenUrl: AppConfig.AccessTokenUrl,
                                               callbackUrl: AppConfig.CallbackUrl
                                              );

			auth.Completed += (s, eventArgs) =>
            {
	            if (eventArgs.IsAuthenticated)
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

            var request = new OAuth1Request("GET",
											new Uri("https://api.twitter.com/1.1/account/verify_credentials.json "),
	                                        null,
	                                        loggedInAccount
                                           );
            //var ui = auth.GetUI(this);
            DependencyService.Get<ITwitterLoginUi>().DisplayUI(auth);
            auth.Completed += (sender, e) => 
            {
                
            };

        }
    }
}
