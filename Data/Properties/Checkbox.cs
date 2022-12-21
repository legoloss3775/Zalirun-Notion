using Newtonsoft.Json;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Checkbox : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("checkbox")]
        public bool Checked;
    }


}
