using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientWrapper.Contracts
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string requestUri);
    }    
}