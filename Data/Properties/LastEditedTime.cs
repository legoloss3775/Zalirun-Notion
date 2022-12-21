using Newtonsoft.Json;
using System;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class LastEditedTime : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("last_edited_time")]
        public DateTime Date;
    }


}
