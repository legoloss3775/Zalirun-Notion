using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Zalirun.Notion.Core;
using Zalirun.Notion.Data;

namespace Zalirun.Notion
{
    public class NotionDatabaseData<T> : INotionData where T : class, INotionDataProperties
    {
        [JsonProperty("results")]
        public List<Result<T>> Results { get; set; }
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("next_cursor")]
        public object NextCursor { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("page")]
        public Page Page { get; set; }
    }
}
