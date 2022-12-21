using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Zalirun.Notion.Core
{
    public class NotionConnection
    {
        public string NotionToken { get; private set; }
        public string NotionVersion { get; private set; }

        public NotionConnection(string token, string notionVersion)
        {
            NotionToken = token;
            NotionVersion = notionVersion;
        }
    }
}
