﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using SampleApiClient.Models;

namespace SampleApiClient.Models
{
    public static partial class FeedItemCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<FeedItem> DeserializeJson(JToken inputObject)
        {
            IList<FeedItem> deserializedObject = new List<FeedItem>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                FeedItem feedItem = new FeedItem();
                feedItem.DeserializeJson(iListValue);
                deserializedObject.Add(feedItem);
            }
            return deserializedObject;
        }
    }
}
