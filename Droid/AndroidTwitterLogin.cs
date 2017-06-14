using System;
using Xamarin.Auth;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using TwitReader.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidTwitterLogin))]
namespace TwitReader.Droid
{
    public class AndroidTwitterLogin : ITwitterLoginUi
    {
        public void DisplayUI(OAuth1Authenticator authenticator)
        {
            var ui = authenticator.GetUI(Android.App.Application.Context.ApplicationContext);
            //var activity = Forms.Context as Activity;
            //activity.StartActivityForResult(ui, -1);
            ((Activity)Forms.Context).StartActivityForResult(ui, -1);
        }
    }
}
