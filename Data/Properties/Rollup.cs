using Newtonsoft.Json;
using System.Collections.Generic;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Rollup<T> : INotionDataProperties where T: INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("rollup")]
        public RollupData<T> Data;
    }
    public class RollupData<T> : INotionDataType where T : INotionPropertyData
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("array")]
        public List<T> Array;

        [JsonProperty("function")]
        public string Function;
    }

}
