using Newtonsoft.Json;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class LastEditedBy : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("last_edited_by")]
        public LastEditedByData LastEditedByData;
    }
    public class LastEditedByData : INotionDataType
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
    public class LastEditedByResult : INotionDataType 
    {
        [JsonProperty("object")]
        public string Object;

        [JsonProperty("id")]
        public string Id;
    }
}
