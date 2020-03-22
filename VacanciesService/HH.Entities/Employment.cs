using Newtonsoft.Json;

namespace HH.Entities
{
    public class Employment
    {
        [JsonProperty("name")] public string Name { get; set; }
    }
}