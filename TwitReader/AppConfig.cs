using System;
namespace TwitReader
{
    public static class AppConfig
    {
        public static readonly string ConsumerKey = "fSWQuqeVX3lEzSzhKlXMal5lB";
        public static readonly string ConsumerSecretKey = "hSGCQTKlFsrlzPl1QJPkcMmxzPVnUUzln4UnWA7UXJMGTjJYIL";
        public static Uri RequestTokenUrl = new Uri("https://api.twitter.com/oauth/request_token");
        public static Uri AuthorizeUrl = new Uri("https://api.twitter.com/oauth/authorize");
        public static Uri AccessTokenUrl = new Uri("https://api.twitter.com/oauth/access_token");
        public static Uri CallbackUrl = new Uri("http://twitter.com");
        public static Uri AppOnlyAuthenticationUrl = new Uri("https://api.twitter.com/oauth2/token");
    }
}
