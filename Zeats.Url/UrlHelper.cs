using System;

namespace Zeats.Url
{
    public static class UrlHelper
    {
        public static bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        public static bool IsValidHttpUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
                   && uriResult.Scheme == Uri.UriSchemeHttp;
        }

        public static bool IsValidHttpsUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
                   && uriResult.Scheme == Uri.UriSchemeHttps;
        }
    }
}