using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class External : INotionDataType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
