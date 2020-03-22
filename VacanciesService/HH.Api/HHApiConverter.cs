using System.Collections.Generic;
using HH.Entities;
using HH.Entities.Additional;
using Newtonsoft.Json;

namespace HH.Api
{
    public static class HHApiConverter
    {
        public static IEnumerable<Vacancy> FromJson(string json)
        {
            IEnumerable<Vacancy> converted = JsonConvert.DeserializeObject<Response>(json).Items;
            return converted;
        }
    }
}