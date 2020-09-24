﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Model.Models
{
    public static class ObjectExtension
    {
        public static JsonSerializer JsonSerializerSettings { get; set; }

        static ObjectExtension()
        {
            JsonSerializerSettings = new JsonSerializer
            {
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        public static IDictionary<string, string> ToKeyValue(this object metaToken)
        {
            if (metaToken == null)
            {
                return null;
            }


            if (!(metaToken is JToken token))
            {
                try
                {
                    return ToKeyValue(JObject.FromObject(metaToken, JsonSerializerSettings));
                }
                catch (System.ArgumentException ex)
                {
                    var dict = new Dictionary<string, string>
                    {
                        { "id", metaToken.ToString() }
                    };
                    return dict;
                }

            }

            if (token.HasValues)
            {
                var contentData = new Dictionary<string, string>();
                foreach (var child in token.Children().ToList())
                {
                    var childContent = child.ToKeyValue();
                    if (childContent != null)
                    {
                        contentData = contentData.Concat(childContent)
                            .ToDictionary(k => k.Key, v => v.Value);
                    }
                }

                return contentData;
            }

            var jValue = token as JValue;
            if (jValue?.Value == null)
            {
                return null;
            }

            var value = jValue?.Type == JTokenType.Date ?
                jValue?.ToString("u", CultureInfo.InvariantCulture) :
                jValue?.ToString(CultureInfo.InvariantCulture);

            return new Dictionary<string, string> { { token.Path, value } };
        }

        public static async Task<string> ToQueryString(this object metaToken)
        {
            var keyValueContent = metaToken.ToKeyValue();
            var formUrlEncodedContent = new FormUrlEncodedContent(keyValueContent);
            var urlEncodedString = await formUrlEncodedContent.ReadAsStringAsync();

            return urlEncodedString;
        }

        public static async Task<string> WithQueryString(this string url, object metaToken)
        {
            if (metaToken != null)
            {
                url += await metaToken.ToQueryString();
            }

            return url;
        }



    }
}