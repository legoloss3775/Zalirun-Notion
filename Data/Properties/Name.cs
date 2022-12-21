using Newtonsoft.Json;
using System.Collections.Generic;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Name : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("title")]
        public List<Title> Title;
    }


}
