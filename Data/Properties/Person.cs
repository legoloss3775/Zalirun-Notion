using Newtonsoft.Json;
using System.Collections.Generic;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Person : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("people")]
        public List<PersonData> People;
    }
    public class PersonData : INotionDataType
    {
        [JsonProperty("email")]
        public string Email;
    }

}
