using Newtonsoft.Json;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Number : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("number")]
        public double Value;
    }


}
