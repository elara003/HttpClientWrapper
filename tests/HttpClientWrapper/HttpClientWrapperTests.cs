using HttpClientWrapper.Src.Contracts;
using NUnit.Framework;

namespace HttpClientWrapper.Tests
{
    [TestFixture]
    public class HttpClientWrapperTests
    {
        [Test]
        public void CallsGooglesWebsite()
        {
            IHttpClient client = new HttpClientWrapper.Src.Wrappers.HttpClientWrapper();
            var response = client.GetStringAsync("https://www.google.com").Result;
            Assert.IsTrue(response.Contains("google"));
        }
    }
}