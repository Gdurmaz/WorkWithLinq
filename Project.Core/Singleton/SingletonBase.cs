using System;
using Project.Core.Connection;
namespace Project.Core.Singleton
{
    public class SingletonBase
    {
        protected ConnectionDb _connDb { get; set; }
        private object _lock = new object();
        protected SingletonBase()
        {
            GetConnectionDb();
        }
        private  ConnectionDb GetConnectionDb()
        {
            if (_connDb == null)
            {
                lock (_lock)
                {
                    if (_connDb==null)
                    {
                        _connDb = new ConnectionDb();
                    }
                }
            }
            return _connDb;
        }
    }
}
