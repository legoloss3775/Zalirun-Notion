using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLog;
using Zalirun.Notion.Core;
using Zalirun.Notion.Data;

namespace Zalirun.Notion
{
    public class NotionDatabase<T> : INotionDatabase where T : INotionDataProperties
    {
        private static ILogger s_logger = NLog.LogManager.GetCurrentClassLogger();
        public string DatabaseId { get; set; }
        public NotionConnection NotionConnection { get; private set; }

        public NotionDatabase(string databaseId, NotionConnection notionConnection)
        {
            DatabaseId = databaseId;
            NotionConnection = notionConnection;
        }

        public async Task<string> Get(string uri)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(uri),
                    Headers =
                    {
                        { "accept", "application/json" },
                        { "Notion-Version", NotionConnection.NotionVersion },
                        {  "Authorization" , "Bearer " + NotionConnection.NotionToken}
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    return body;
                }
            }
            catch (Exception e)
            {
                s_logger.Error(e);
                return "";
            }
        }
        public async Task<string> UpdatePage(string data, string pageId)
        {
            try
            {
                return await PatchAsync(
                    $"https://api.notion.com/v1/pages/{pageId}",
                    data);
            }
            catch (Exception e)
            {
                s_logger.Error(e);
                return "";
            }
        }
        public async Task<string> QueryPostAsync(string filters = "")
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri($"https://api.notion.com/v1/databases/{DatabaseId}/query"),
                    Headers =
                    {
                        { "accept", "application/json" },
                        { "Notion-Version", NotionConnection.NotionVersion },
                        {  "Authorization" , "Bearer " + NotionConnection.NotionToken}
                    },
                    Content = new StringContent(filters)
                    {
                        Headers =
                        {
                            ContentType = new MediaTypeHeaderValue("application/json")
                        }
                    }
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    return body;
                }
            }
            catch (Exception e)
            {
                s_logger.Error(e);
                return "";
            }
        }
        public async Task<string> PatchAsync(string uri, string data)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = new HttpMethod("PATCH"),
                    RequestUri = new Uri(uri),
                    Headers =
                    {
                        { "accept", "application/json" },
                        { "Notion-Version", NotionConnection.NotionVersion },
                        {  "Authorization" , "Bearer " + NotionConnection.NotionToken}
                    },
                    Content = new StringContent(data)
                    {
                        Headers =
                        {
                            ContentType = new MediaTypeHeaderValue("application/json")
                        }
                    }
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    return body;
                }
            }
            catch (Exception e)
            {
                s_logger.Error(e);
                return "";
            }
        }
    }
}
