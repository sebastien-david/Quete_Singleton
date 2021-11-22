using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Singleton
{
    public sealed class DatabaseSingleton
    {
        private static DatabaseSingleton instance = null;
        private static readonly object padlock = new object();

        private DatabaseSingleton() { }

        public static DatabaseSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseSingleton();
                    }
                    return instance;
                }
            }
        }



    }
}
