using Newtonsoft.Json;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Select : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("select")]
        public string Value;
    }


}
