using NUnit.Framework;
using HttpClientWrapper.Contracts;

namespace HttpClientWrapperTests
{
    [TestFixture]
    public class HttpClientWrapperTests
    {
        [Test]
        public void CallsGooglesWebsite()
        {
            IHttpClient client = new HttpClientWrapper.Wrappers.HttpClientWrapper();
            var response = client.GetStringAsync("https://www.google.com").Result;
            Assert.IsTrue(response.Contains("google"));
        }
    }
}