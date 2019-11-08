using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_bong_da
{
    public static class Bien
    {
        public static string connet = @"\QL_BongDa.db";
        public static int ID;
        public static string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public static string IDCLB;
        public static string IDNha = null;
        public static string IDKhach = null;
        public static string CapNhat = null;
        public static int a;
        public static int b;
    }
}
