//********************************************************* 
// 
//    Copyright (c) Microsoft. All rights reserved. 
//    This code is licensed under the Microsoft Public License. 
//    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF 
//    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY 
//    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR 
//    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT. 
// 
//*********************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TwitterClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Configure Twitter OAuth
            var oauthToken = ConfigurationManager.AppSettings["oauth_token"];
            var oauthTokenSecret = ConfigurationManager.AppSettings["oauth_token_secret"];
            var oauthCustomerKey = ConfigurationManager.AppSettings["oauth_consumer_key"];
            var oauthConsumerSecret = ConfigurationManager.AppSettings["oauth_consumer_secret"];
            var keywords = ConfigurationManager.AppSettings["twitter_keywords"];

            //Configure EventHub
            var eventHubConfig = new EventHubConfig();
            eventHubConfig.ConnectionString = ConfigurationManager.AppSettings["EventHubConnectionString"];
            eventHubConfig.EventHubName = ConfigurationManager.AppSettings["EventHubName"];
            var myEventHubObserver = new EventHubObserver(eventHubConfig);

            var twitterConfig = new TwitterConfig(oauthToken, oauthTokenSecret, oauthCustomerKey, oauthConsumerSecret,
                keywords);
            var datum = Tweet.StreamStatuses(twitterConfig)
                             .Select(tweet => Sentiment.ComputeScore(tweet, keywords));
                             //.Select(tweet => new Payload { CreatedAt= tweet.CreatedAt, Topic = tweet.Topic , SentimentScore = tweet.SentimentScore });

            datum.ToObservable().Subscribe(myEventHubObserver);
        }
    }
}
