using System.Threading.Tasks;
using RestEase;
using ZbW.Testing.WpfSample.Libs.IpInfoInterface.Api.Responses;

namespace ZbW.Testing.WpfSample.Libs.IpInfoInterface.Api
{
    [Header("User-Agent", "RestEase")]
    [Header("accept", "application/json")]
    public interface IIpInfoApi
    {
        [Get("{ip}")]
        Task<GetInfoResponse> GetInfoAsync([Path] string ip);
    }
}