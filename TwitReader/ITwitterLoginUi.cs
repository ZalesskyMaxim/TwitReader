using System;
using Xamarin.Auth;

namespace TwitReader
{
    public interface ITwitterLoginUi
    {
        void DisplayUI(OAuth1Authenticator authenticator);
    }
}
