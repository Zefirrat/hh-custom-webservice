using Newtonsoft.Json;

namespace HH.Entities.Additional
{
    public class Response
    {
        [JsonProperty("items")] public Vacancy[] Items { get; set; }
    }
}