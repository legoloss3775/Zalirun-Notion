using System.Collections.Generic;

namespace Zalirun.Notion.Core
{
    public interface INotionConfigurator
    {
        string GetNotionToken();
        string GetNotionVersion();
        string[] GetNotionDatabaseIds(string databaseName);
    }
}