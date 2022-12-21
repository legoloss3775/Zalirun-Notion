using Newtonsoft.Json;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Formula : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("formula")]
        public FormulaData String;
    }
    public class FormulaData : INotionDataType
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("string")]
        public object String;
    }

}
