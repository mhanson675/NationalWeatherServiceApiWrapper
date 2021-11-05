using System.Collections.Specialized;
using System.Threading.Tasks;

namespace NationalWeatherServiceAPIClientLibrary
{
    public interface IWebClient
    {
        byte[] Get(string url);

        Task<byte[]> GetAsync(string url);

        byte[] Post(string url, NameValueCollection postData);
    }
}
