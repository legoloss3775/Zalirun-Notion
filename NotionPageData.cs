using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Zalirun.Notion.Data;

namespace Zalirun.Notion.Core
{
    public class NotionPageData<T> : INotionData where T : INotionDataProperties
    {
        [JsonProperty("properties")]
        public T Properties;
        [JsonProperty("object")]
        public string Object;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("created_time")]
        public DateTime CreatedTime;

        [JsonProperty("last_edited_time")]
        public DateTime LastEditedTime;

        [JsonProperty("created_by")]
        public CreatedBy CreatedBy;

        [JsonProperty("last_edited_by")]
        public LastEditedByData LastEditedBy;

        [JsonProperty("cover")]
        public object Cover;

        [JsonProperty("icon")]
        public Icon Icon;

        [JsonProperty("parent")]
        public Parent Parent;

        [JsonProperty("archived")]
        public bool Archived;

        [JsonProperty("url")]
        public string Url;
    }
}
