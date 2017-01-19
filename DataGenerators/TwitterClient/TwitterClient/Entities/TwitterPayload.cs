using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClient
{
    public class TwitterPayload
    {
        public Int64 ID;
        public DateTime CreatedAt;
        public string UserName;
        public string TimeZone;
        public string ProfileImageUrl;
        public string Text;
        public string Language;
        public string Topic;
        public int SentimentScore;

        public string RawJson;

        public override string ToString()
        {
            return new { ID, CreatedAt, UserName, TimeZone, ProfileImageUrl, Text, Language, Topic, SentimentScore }.ToString();
        }
    }
}
