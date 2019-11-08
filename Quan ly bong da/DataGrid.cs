using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Quan_ly_bong_da
{
    class DataGrid
    {
        public static DataTable BangData(string command)
        {
            DataTable tmp = new DataTable();
            using (SQLiteConnection con = Connect.getCon())
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = command;
                    cmd.ExecuteNonQuery();
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    da.Fill(tmp);
                }
                con.Close();
            }
            return tmp;
        }
        public static string returnID(int a)
        {
            string tmp=null;
            DataTable da = BangData("SELECT ID FROM CAULACBO ORDER BY Diem Desc");
            DataRow row;
            row = da.Rows[a];
            tmp = row[0].ToString();
            return tmp;
        }
        public static string[] LayData()
        {
            string[] danhsachclb = new string[50];

            DataTable dt = DataGrid.BangData("select TenCLB From CAULACBO");
            DataRow row;
            for (int i = 0; i < 16; i++)
            {
                row = dt.Rows[i];
                danhsachclb[i] = row[0].ToString();
            }
            return danhsachclb;
        }
    }
}
