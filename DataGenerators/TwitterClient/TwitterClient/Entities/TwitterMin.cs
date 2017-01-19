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
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;

namespace TwitterClient
{
    public class TwitterMin
    {
        public Int64 ID;
        public DateTime CreatedAt;
        public string UserName;
//        public string TimeZone;
//        public string ProfileImageUrl;
        public string Text;
//        public string Language;
        public string Topic;
        public int SentimentScore;

//        public string RawJson;

        public override string ToString()
        {
            return new { ID, CreatedAt, UserName, Text, Topic, SentimentScore }.ToString();
        }
    }
}
