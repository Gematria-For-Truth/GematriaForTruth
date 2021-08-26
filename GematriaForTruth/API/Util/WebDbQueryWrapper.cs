// Copyright (c) 2020 Gematria Tools
using GematriaForTruth.API.Factory;
using System.Net.Http;
using System.Threading.Tasks;

namespace GematriaForTruth.API.Util
{
    public class WebDbQueryWrapper
    {
        public string WebURL { get; }
        public int ServerThrottle { get; set; }

        public WebDbQueryWrapper(string urlString, int serverThrottleValue)
        {
            this.WebURL = urlString;
            this.ServerThrottle = serverThrottleValue;
        }

        public async Task<string[]> FindCipherMatchsByValue(string cypher, long value)
        {
            string[] individualMatches = new string[0];
            using (HttpClient theClient = new HttpClient())
            {
                string url = WebURL + cypher.Replace(" ", "_") + "-" + value;
                using (HttpResponseMessage response = await theClient.GetAsync(url))
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    try
                    {
                        response.EnsureSuccessStatusCode();
                    }
                    catch (HttpRequestException ex)
                    {
                        LoggerFactory.Instance().LogException(ex);
                    }
                    if (responseBody.Trim().Length != 0)
                    {
                        if (responseBody.Contains("-"))
                            individualMatches = responseBody.Split('-');
                        else
                        {
                            individualMatches = new string[1];
                            individualMatches[0] = responseBody;
                        }
                    }
                }
            }
            return individualMatches;
        }
    }
}
