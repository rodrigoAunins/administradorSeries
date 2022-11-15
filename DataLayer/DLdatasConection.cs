using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSeriesPS.DataLayer
{
    public sealed class DLdatasConection
    {

        private string host;
        private string port;
        private string db;
        private string user;
        private string pass;

        public string Host { get => host; set => host = value; }
        public string Port { get => port; set => port = value; }
        public string Db { get => db; set => db = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }

        // The Singleton's constructor should always be private to prevent
        // direct construction calls with the `new` operator.
        private DLdatasConection(string host, string port, string db, string user, string pass) { Host = host; Port = port; Db = db; User = user; Pass = pass; }

            // The Singleton's instance is stored in a static field. There there are
            // multiple ways to initialize this field, all of them have various pros
            // and cons. In this example we'll show the simplest of these ways,
            // which, however, doesn't work really well in multithreaded program.
            private static DLdatasConection _instance;

            // This is the static method that controls the access to the singleton
            // instance. On the first run, it creates a singleton object and places
            // it into the static field. On subsequent runs, it returns the client
            // existing object stored in the static field.
            public static DLdatasConection GetInstance(string host, string port, string db, string user, string pass)
            {
                if (_instance == null)
                {
                    _instance = new DLdatasConection(host,port, db, user, pass);
                }
                return _instance;
            }

            // Finally, any singleton should define some business logic, which can
            // be executed on its instance.
            public void someBusinessLogic()
            {
                // ...
            }
        }
    
}
