using System.Collections.Specialized;
using System.Linq;
using System.Net;

namespace OneDriveRestAPI.Util
{
    public static class NameValueCollectionExtensions
    {
        public static string ToQueryString(this NameValueCollection nvc, bool includePrefix = true)
        {
            var array = (from key in nvc.AllKeys
                from value in nvc.GetValues(key)
                select string.Format("{0}={1}", WebUtility.UrlEncode(key), WebUtility.UrlEncode(value)))
                .ToArray();
            return (includePrefix ? "?" : "") + string.Join("&", array);
        }

        public static NameValueCollection ToNameValueCollection(this string queryString)
        {
            var nvc = new NameValueCollection();

            foreach (string x in queryString.Split('&'))
            {
                string[] kvp = x.Split('=');
                nvc[kvp[0]] = kvp[1];
            }

            return nvc;
        }
    }
}