using System;
using TwitReader.iOS;
using UIKit;
using Xamarin.Auth;

[assembly: Xamarin.Forms.Dependency(typeof(IosTwitterLogin))]
namespace TwitReader.iOS
{
    public class IosTwitterLogin : ITwitterLoginUi
    {
        public void DisplayUI(OAuth1Authenticator authenticator)
        {
            var ui = authenticator.GetUI();
            (UIApplication.SharedApplication.Delegate as AppDelegate).window.RootViewController.PresentViewController(ui, true, null);
        }
    }
}
