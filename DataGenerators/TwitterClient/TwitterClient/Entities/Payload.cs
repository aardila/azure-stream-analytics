using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClient
{
    public class Payload
    {
        public DateTime CreatedAt;
        public string Topic;
        public int SentimentScore;

        public override string ToString()
        {
            return new { CreatedAt, Topic, SentimentScore }.ToString();
        }
    }
}
