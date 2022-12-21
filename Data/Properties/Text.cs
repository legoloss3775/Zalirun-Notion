using Newtonsoft.Json;
using System.Collections.Generic;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class Text : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("rich_text")]
        public List<RichText> RichText;
    }


}
