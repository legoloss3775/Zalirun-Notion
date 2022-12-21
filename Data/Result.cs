using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Zalirun.Notion.Core;
using Zalirun.Notion.Data;

namespace Zalirun.Notion.Data
{
    public class Result<T> where T : INotionDataProperties
    {
        [JsonProperty("properties")]
        public T Properties { get; set; }
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_time")]
        public DateTime CreatedTime { get; set; }

        [JsonProperty("last_edited_time")]
        public DateTime LastEditedTime { get; set; }

        [JsonProperty("created_by")]
        public CreatedByResult CreatedBy { get; set; }

        [JsonProperty("last_edited_by")]
        public LastEditedByResult LastEditedBy { get; set; }

        [JsonProperty("cover")]
        public object Cover { get; set; }

        [JsonProperty("icon")]
        public Icon Icon { get; set; }

        [JsonProperty("parent")]
        public Parent Parent { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
