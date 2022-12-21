using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Title : INotionDataType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public Text Text { get; set; }

        [JsonProperty("annotations")]
        public Annotations Annotations { get; set; }

        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        [JsonProperty("href")]
        public object Href { get; set; }
    }
}
