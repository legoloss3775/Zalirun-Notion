using Newtonsoft.Json;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class CreatedBy : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("created_by")]
        public CreatedByData CreatedByData;
    }

    public class CreatedByData : INotionDataType
    {
        [JsonProperty("object")]
        public string Object;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("avatar_url")]
        public string AvatarUrl;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("person")]
        public Person Person;
    }
    public class CreatedByResult : INotionDataType
    {
        [JsonProperty("object")]
        public string Object;

        [JsonProperty("id")]
        public string Id;
    }
}
