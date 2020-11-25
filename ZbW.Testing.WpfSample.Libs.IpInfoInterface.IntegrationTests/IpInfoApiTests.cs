using NUnit.Framework;
using RestEase;
using ZbW.Testing.WpfSample.Libs.IpInfoInterface.Api;

namespace ZbW.Testing.WpfSample.Libs.IpInfoInterface.IntegrationTests
{
    [TestFixture]
    internal class IpInfoApiTests
    {
        private const string GoogleDnsIp = "8.8.8.8";

        private const string GoogleDnsHostname = "dns.google";

        [Test]
        public void IpInfoApi_BaseFunctionality_ReturnInfoFromApi()
        {
            //Arrange
            var sut = RestClient.For<IIpInfoApi>("https://ipinfo.io");

            //Act
            var result = sut.GetInfoAsync(GoogleDnsIp).Result;

            //Assert
            Assert.That(result.Hostname, Is.EqualTo(GoogleDnsHostname));
        }
    }
}