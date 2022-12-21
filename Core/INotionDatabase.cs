using System.Threading.Tasks;

namespace Zalirun.Notion.Core
{
    public interface INotionDatabase
    {
        string DatabaseId { get; set; }
        NotionConnection NotionConnection { get; }
        Task<string> Get(string uri);
        Task<string> UpdatePage(string data, string pageId);
        Task<string> QueryPostAsync(string filters = "");
        Task<string> PatchAsync(string uri, string data);
    }
}