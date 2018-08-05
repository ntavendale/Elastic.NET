using System;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace endpoint
{
    public class EndpointClient
    {
        private string _baseURL;
        private string _userName;
        private string _password;
        private string _resource;

        public EndpointClient(string url, string userName, string password, string resource, UInt16 port = 0)
        {
            if (0 != port)
            {
                _baseURL = string.Format("{0}:{1}", url, port);
            }
            else
            {
                _baseURL = url;
            }
            _userName = userName;
            _password = password;
            _resource = resource;
        }

        public string FullURL
        {
            get { return string.Format("{0}/{1}", _baseURL, _resource); }
        }

        public async Task<string> Get()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(this.FullURL).ConfigureAwait(continueOnCapturedContext: false))
                {
                    using (HttpContent content = response.Content)
                    {
                        // ... Read the string.
                        string result = await content.ReadAsStringAsync();
                        return result;
                    }
                }
            }
        }
        public async Task<HttpStatusCode> HeadAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseURL);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, _resource);
                using (HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(continueOnCapturedContext: false))
                {
                    return response.StatusCode;
                }
            }
        }
        public async Task<HttpStatusCode> PutAsync(string putData)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header
                var stringContent = new StringContent(putData, Encoding.UTF8, "application/json");
                using (HttpResponseMessage response = await client.PutAsync(this.FullURL, stringContent).ConfigureAwait(continueOnCapturedContext: false))
                {
                    return response.StatusCode;
                }
            }
        }

        public async Task<HttpStatusCode> PostAsync(string putData)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header
                var stringContent = new StringContent(putData, Encoding.UTF8, "application/json");
                using (HttpResponseMessage response = await client.PostAsync(this.FullURL, stringContent).ConfigureAwait(continueOnCapturedContext: false))
                {
                    return response.StatusCode;
                }
            }
        }
    }

}
