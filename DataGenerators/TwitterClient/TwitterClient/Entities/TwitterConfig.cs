using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClient
{
    public struct TwitterConfig
    {
        public readonly string OAuthToken;
        public readonly string OAuthTokenSecret;
        public readonly string OAuthConsumerKey;
        public readonly string OAuthConsumerSecret;
        public readonly string Keywords;

        public TwitterConfig(string oauthToken, string oauthTokenSecret, string oauthConsumerKey, string oauthConsumerSecret, string keywords)
        {
            OAuthToken = oauthToken;
            OAuthTokenSecret = oauthTokenSecret;
            OAuthConsumerKey = oauthConsumerKey;
            OAuthConsumerSecret = oauthConsumerSecret;
            Keywords = keywords;
        }
    }
}
