using NUnit.Framework;
using NSubstitute;
using SampleApp;
using HttpClientWrapper.Contracts;
using FluentAssertions;
using System.Threading.Tasks;

namespace Tests.SampleApp
{
    public class Tests
    {
        private GoogleClient _sut;
        private const string _response = "google response";

        [SetUp]
        public void Setup()
        {
            var httpClient = Substitute.For<IHttpClient>();
            var taskReturn = Task.FromResult(_response);
            httpClient.GetStringAsync("www.google.com").Returns(taskReturn);
            _sut = new GoogleClient(httpClient);
        }

        [Test]
        public void GetGoogleSearchPage_ReturnsTheResponseFrom_Google()
        {
            var response = _sut.GetGoogleSearchPage();
            response.Should().Be(_response);
        }
    }
}
