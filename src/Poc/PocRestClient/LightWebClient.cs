using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;

namespace LightwebClientNamespace
{
    public class LightWebClient
    {
        protected Dictionary<string,HttpClient> _httpClient = new Dictionary<string, HttpClient>();
        
        // empty constructor not allowed
        private LightWebClient() { }

        public LightWebClient(string pUsername, string pPassword)
        {
            var handler = new HttpClientHandler();
            if (!string.IsNullOrEmpty(pUsername)) handler.Credentials = new NetworkCredential(pUsername, pPassword);
            
            _httpClient.Add("XML", new HttpClient(handler));
            var client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.Add("JSON", client);
            

        }
        public async Task<Stream> GetStreamAsync(String pUri, String pRequestType = "XML")
        {
            if (_httpClient[pRequestType] == null) throw new Exception("HttpClient not set!");
            try
            {
                var httpResponse = await _httpClient[pRequestType].GetAsync(pUri);
                httpResponse.EnsureSuccessStatusCode();
                return await httpResponse.Content.ReadAsStreamAsync(); ;
            }
            catch (Exception ex)
            {
                // to log this
                string errorMessage = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;
                throw;
            }
        }

    }
}