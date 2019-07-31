using System;
using HttpClientWrapper.Contracts;

namespace SampleApp
{
    public class GoogleClient
    {
        private IHttpClient _client;
        public GoogleClient(IHttpClient client)
        {
            _client = client;
        }

        public string GetGoogleSearchPage()
        {
            return  _client.GetStringAsync("www.google.com").Result;
        }
    }
}
