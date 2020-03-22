using Newtonsoft.Json;

namespace HH.Entities
{
    public class Employer
    {
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("url")] public string Url { get; set; }
    }
}