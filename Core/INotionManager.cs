using System;
using System.Collections.Generic;
using System.Text;

namespace Zalirun.Notion.Core
{
    public interface INotionManager<T> where T : INotionDatabase
    {
        void Init(string token, string version, params string[] databaseIds);
        void Run();
    }
}
