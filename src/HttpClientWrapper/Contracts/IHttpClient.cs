using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientWrapper.Src.Contracts
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string requestUri);
    }    
}