using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Quan_ly_bong_da
{
     class Connect
    {
        public static SQLiteConnection getCon()
        {
            string connectstring = "Data Source=" + System.Environment.CurrentDirectory + Bien.connet;
            SQLiteConnection conn = new SQLiteConnection(connectstring);
            return conn;
        }
    }
}
