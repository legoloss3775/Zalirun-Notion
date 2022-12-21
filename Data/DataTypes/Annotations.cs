using Newtonsoft.Json;
using System.Text;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{

    public class Annotations : INotionDataType
    {
        [JsonProperty("bold")]
        public bool Bold { get; set; }

        [JsonProperty("italic")]
        public bool Italic { get; set; }

        [JsonProperty("strikethrough")]
        public bool Strikethrough { get; set; }

        [JsonProperty("underline")]
        public bool Underline { get; set; }

        [JsonProperty("code")]
        public bool Code { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }


}
