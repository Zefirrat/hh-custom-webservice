using Newtonsoft.Json;

namespace HH.Entities
{
    public class Snippet
    {
        [JsonProperty("requirement")] public string Requirement { get; set; }

        [JsonProperty("responsibility")] public string Responsibility { get; set; }
    }
}