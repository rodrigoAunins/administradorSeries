using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminSeriesPS.DataLayer;

namespace AdminSeriesPS.BusinessLayer
{
    class BLDataBase
    {
        public bool connect(string host,string port,string db, string user, string pass)
        {
            DataLayer.DLdataBase connection = new DataLayer.DLdataBase();
            bool connectOk = connection.connect(host,port,db,user,pass);
            return connectOk;
            
        }

        public void close()
        {
            DataLayer.DLdataBase connection = new DataLayer.DLdataBase();
            connection.close();
        }
    }
}
