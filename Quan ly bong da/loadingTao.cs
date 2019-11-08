using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_bong_da
{
    public partial class loadingTao : Form
    {
        public loadingTao()
        {
            InitializeComponent();
        }

        private void loadingTao_Load(object sender, EventArgs e)
        {
            string[] arr = new string[100];
            string[] arrdoi = new string[100];
            arr = DataGrid.LayData();
            for (int i = 0; i < 15; i++)
            {
                arrdoi[i] = arr[i];
                arrdoi[i + 15] = arr[i];
                arrdoi[i + 30] = arr[i];
            }
            try
            {
                string[] query =
                {
                    "UPDATE CAULACBO SET Diem=0,HieuSo=0",
                    "UPDATE TranDauTest SET CapNhat='Chua'",
                    "UPDATE DanSach SET Ten=NULL,SoBanThang=NULL"
                };
                sql.IUD(query[0]);
                sql.IUD(query[1]);
                sql.IUD(query[2]);
                for (int i = 1; i < 16; i++)
                {
                    sql.IUD("UPDATE  LICHTHIDAUTest SET Tran1='v" + i + "t1',Tran2='v" + i + "t2',Tran3='v" + i + "t3',Tran4='v" + i + "t4',Tran5='v" + i + "t5',Tran6='v" + i + "t6',Tran7='v" + i + "t7', Tran8='v" + i + "t8' WHERE IDVong=" + i);
                }
                for (int i = 1; i < 16; i++)
                {
                    sql.IUD("UPDATE TranDauTest SET Khach='" + arr[i - 1] + "',Nha='" + arr[15] + "',a=NULL,b=NULL,DsGhiban1=NULL,DsGhiban2=NULL Where IDTran='v" + i + "t" + 1 + "'");
                    for (int j = 2; j < 9; j++)
                    {
                        sql.IUD("UPDATE TranDauTest SET Khach='" + arrdoi[i + j - 2] + "',Nha='" + arrdoi[30 + i - j] + "',a=NULL,b=NULL,DsGhiban1=NULL,DsGhiban2=NULL Where IDTran='v" + i + "t" + j + "'");
                    }
                }
                for (int i = 1; i < 16; i++)
                {
                    int tmp = i + 15;
                    sql.IUD("UPDATE TranDauTest SET Nha='" + arr[i - 1] + "',Khach='" + arr[15] + "',a=NULL,b=NULL,DsGhiban1=NULL,DsGhiban2=NULL Where IDTran='v" + tmp + "t" + 1 + "'");
                    for (int j = 2; j < 9; j++)
                    {
                        sql.IUD("UPDATE TranDauTest SET Nha='" + arrdoi[i + j - 2] + "',Khach='" + arrdoi[30 + i - j] + "',a=NULL,b=NULL Where IDTran='v" + tmp + "t" + j + "'");
                    }
                }
            }
            catch (Exception)
            {

            }
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                this.Close();
            }
        }
    }
}
