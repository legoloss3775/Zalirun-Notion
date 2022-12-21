using Newtonsoft.Json;
using System;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class CreatedTime : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("created_time")]
        public DateTime Date;
    }


}
