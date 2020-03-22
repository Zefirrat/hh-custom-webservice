using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using HH.Entities.Additional;
using Newtonsoft.Json;

namespace HH.Api
{
    public class HHApiRequest
    {
        private string Url => "https://api.hh.ru/vacancies";
        private string Params => string.Empty;

        private async Task<string> Get(string url)
        {
            string responseJson = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", ".net core");
                var responseStream = await client.GetStreamAsync(url);
                if (responseStream != null)
                    using (var sr = new StreamReader(responseStream))
                    {
                        responseJson = sr.ReadToEnd();
                    }
            }
            return responseJson;
        }

        public async Task<string> Get()
        {
            return await Get(Url);
        }

        public async Task<string> Get(Dictionary<string, string> paramsDictionary)
        {
            List<string> pramsConcat = paramsDictionary.Select(i => string.Concat(i.Key, "=", i.Value)).ToList();
            return await Get(string.Concat(Url, "?", string.Join("&", pramsConcat)));
        }
    }
}