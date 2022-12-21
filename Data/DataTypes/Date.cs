using Newtonsoft.Json;
using System;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Date : INotionDataType
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("date")]
        public DateTime DateTime;
    }


}
