using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Icon : INotionDataType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("external")]
        public External External { get; set; }
    }
}
