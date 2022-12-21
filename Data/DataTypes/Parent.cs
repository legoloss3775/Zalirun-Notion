using Newtonsoft.Json;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Parent : INotionDataType
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("database_id")]
        public string DatabaseId;
    }


}
