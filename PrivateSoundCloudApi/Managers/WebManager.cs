using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using PrivateSoundCloudApi.Entities.Web;
using PrivateSoundCloudApi.Interfaces;

namespace PrivateSoundCloudApi.Managers
{
    public class WebManager : IWebManager
    {
        public WebManager(string authToken = null)
        {
            AuthenticationToken = authToken;
        }

        public bool IsNetworkAvailable => NetworkInterface.GetIsNetworkAvailable();

        public static string AuthenticationToken { get; set; }

        public async Task<Result> GetData(string uri)
        {
            var httpClient = new HttpClient();

            try
            {
                if (!string.IsNullOrEmpty(AuthenticationToken))
                {
                    uri += "&client_id=" + AuthenticationToken;
                }
                var response = await httpClient.GetAsync(uri);
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new WebException("SoundCloud API Error: Service not found.");
                }
                var responseContent = await response.Content.ReadAsStringAsync();
                return string.IsNullOrEmpty(responseContent) ? new Result(response.IsSuccessStatusCode, string.Empty) : new Result(response.IsSuccessStatusCode, responseContent);
            }
            catch (Exception ex)
            {

                throw new WebException("SoundCloud API Error: Service error", ex);
            }
        }
    }
}
