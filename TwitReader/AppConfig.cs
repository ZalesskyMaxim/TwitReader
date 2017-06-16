using System;
namespace TwitReader
{
    public static class AppConfig
    {
        public static readonly string ConsumerKey = "C9iv9Cwq0lrH02qdOk5BTtNYv";
        public static readonly string ConsumerSecretKey = "u4PRH3RSxsSYozWMGPbS809MbZmznxr7k493fW0vjxeJ6q18V9";
        public static Uri RequestTokenUrl = new Uri("https://api.twitter.com/oauth/request_token");
        public static Uri AuthorizeUrl = new Uri("https://api.twitter.com/oauth/authorize");
        public static Uri AccessTokenUrl = new Uri("https://api.twitter.com/oauth/access_token");
        public static Uri CallbackUrl = new Uri("http://twitter.com");
        public static Uri AppOnlyAuthenticationUrl = new Uri("https://api.twitter.com/oauth2/token");
    }
}
