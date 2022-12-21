using Newtonsoft.Json;
using System.Collections.Generic;
using Zalirun.Notion.Core;

namespace Zalirun.Notion.Data
{
    public class FilesMedia : INotionPropertyData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("files")]
        public List<object> Files;
    }


}
