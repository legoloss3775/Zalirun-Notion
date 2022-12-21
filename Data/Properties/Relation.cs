using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Zalirun.Notion.Data
{
    public class Relation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("relation")]
        public List<RelationValue> Value { get; set; }
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }
    public class RelationValue
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
