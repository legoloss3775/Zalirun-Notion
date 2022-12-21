using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace Zalirun.Notion.Core
{
    public abstract class NotionManagerBase<T> : INotionManager<NotionDatabase<T>> where T : INotionDataProperties
    {
        protected static readonly ILogger Logger = NLog.LogManager.GetCurrentClassLogger();
        protected Dictionary<Guid, NotionDatabase<T>> Databases { get; set; } = new Dictionary<Guid, NotionDatabase<T>>();

        public event EventHandler ManagerInit;

        public abstract void Run();

        public virtual void OnManagerInit()
        {
            ManagerInit?.Invoke(this, EventArgs.Empty);
        }
        public void Init(string token, string version, params string[] databaseIds)
        {
            try
            {
                Logger.Info($"Begin >> Init Notion Manager");

                NotionConnection connection = new NotionConnection(token, version);
                Databases = new Dictionary<Guid, NotionDatabase<T>>();
                foreach (var id in databaseIds)
                {
                    Databases.Add(Guid.Parse(id),
                                   (NotionDatabase<T>)Activator.CreateInstance(typeof(NotionDatabase<T>), id, connection));
                }
            }
            catch (Exception e)
            {
                Logger.Error(e, $"Init Telegram Notion Manager failed");
            }
            finally
            {
                OnManagerInit();
                Logger.Info($"End >> Init");
            }
        }
    }
}
