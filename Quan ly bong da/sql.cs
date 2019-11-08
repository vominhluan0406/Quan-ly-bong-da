using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace Quan_ly_bong_da
{
    public static class sql
    {
        public static void IUD(string query)
        {
            try
            {
                using (SQLiteConnection con = Connect.getCon())
                {
                    con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                    }
                        con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public static AutoCompleteStringCollection autoCompleteString(string query)
        {
            AutoCompleteStringCollection tmp = new AutoCompleteStringCollection();
            try
            {
                using (SQLiteConnection con = Connect.getCon())
                {
                    con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = query;
                        SQLiteDataReader daa = cmd.ExecuteReader();
                        while (daa.Read())
                        {
                            tmp.Add(daa.GetString(0));
                        }
                    }
                    con.Close();
                }
                return tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return tmp;
            }
        }
    }
}
