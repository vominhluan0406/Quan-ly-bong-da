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
    public partial class CapnhatKQ : Form
    {
        public CapnhatKQ()
        {
            InitializeComponent();
        }

        private void CapnhatKQ_Load(object sender, EventArgs e)
        {
            tenDoiNha.Text = Bien.IDNha;
            tendoiKhach.Text = Bien.IDKhach;
            string[] query = { "SELECT Img FROM CAULACBO WHERE TenCLB='"+tenDoiNha.Text+"'",
                "SELECT Img FROM CAULACBO WHERE TenCLB='" + tendoiKhach .Text + "'",
                "SELECT Ten FROM CAUTHU WHERE CLB='"+tenDoiNha.Text+"'",
                "SELECT Ten FROM CAUTHU WHERE CLB='"+tendoiKhach.Text+"'",
                "SELECT a,b,DsGhiban1,DsGhiban2,CapNhat FROM TRANDAUTest WHERE Nha='"+tenDoiNha.Text+"' AND Khach='"+tendoiKhach.Text+"'"
            };
            DataRow row = DataGrid.BangData(query[0]).Rows[0];
            picNha.Image = Image.image(row[0].ToString());
            row= DataGrid.BangData(query[1]).Rows[0];
            picKhahc.Image = Image.image(row[0].ToString());
            autocomplteNha.AutoCompleteCustomSource = sql.autoCompleteString(query[2]);
            autocomplteKhach.AutoCompleteCustomSource = sql.autoCompleteString(query[3]);
            row = DataGrid.BangData(query[4]).Rows[0];
            tisoNha.Text = row[0].ToString();
            tisoKhach.Text = row[1].ToString();
            dsGhiBanKhach.Text = row[3].ToString();
            dsghiBanNha.Text = row[2].ToString();
            Bien.CapNhat = row[4].ToString();
            if (Bien.CapNhat == "Roi")
            {
                Bien.a = Convert.ToInt32(tisoNha.Text);
                Bien.b = Convert.ToInt32(tisoKhach.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tenDoiNha_Click(object sender, EventArgs e)
        {

        }
        string tmp;
        private void autocomplteNha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tmp += autocomplteNha.Text + ",";
                dsghiBanNha.Text = tmp;
            }
        }
        string tmp2;
        private void autocomplteKhach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tmp += autocomplteKhach.Text + ",";
                dsGhiBanKhach.Text = tmp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringghiban = null;
            if (int.TryParse(tisoNha.Text,out int tm)&&int.TryParse(tisoKhach.Text,out int tm2))
            {
                string query = "UPDATE TRANDAUTest SET a=" + Convert.ToInt32(tisoNha.Text) + ", b=" + Convert.ToInt32(tisoKhach.Text) + ", DsGhiban1='" + dsghiBanNha.Text +
               "', DsGhiban2='" + dsGhiBanKhach.Text + "' WHERE Nha='" + tenDoiNha.Text + "' AND Khach='" + tendoiKhach.Text + "'";
                sql.IUD(query);
                dsGhiBanKhach.Text =dsghiBanNha.Text= null;
                tmp = tmp2 = null;
                int a = Convert.ToInt32(tisoNha.Text);
                int b = Convert.ToInt32(tisoKhach.Text);
                int diemnha = 0;
                int diemkhach = 0;
                int diema = 0;
                int diemb = 0;
                int hieu1 = 0;
                int hieu2 = 0;
                if (a > b) diemnha = 3;
                else if (b > a) diemkhach = 3;
                else if (a == b) diemnha = diemkhach = 1;
                if (Bien.CapNhat == "Roi")
                {
                    hieu1 = Bien.a;
                    hieu2 = Bien.b;
                    if (Bien.a > Bien.b) diema = 3;
                    else if (Bien.b > Bien.a) diemb = 3;
                    else if (Bien.a == Bien.b) diema = diemb = 1;
                }
                string[] up = { "UPDATE CAULACBO SET Diem=Diem+" + (diemnha - diema) + ", HieuSo=Hieuso+" + (a - b - hieu1 + hieu2) + " WHERE TenCLB='" + tenDoiNha.Text + "'",
                    "UPDATE CAULACBO SET Diem=Diem+" + (diemkhach - diemb) + ", HieuSo=HieuSo+" + (b - a - hieu2 + hieu1) + " WHERE TenCLB='" + tendoiKhach.Text + "'",
                    "UPDATE TranDauTest SET CapNhat='Roi' WHERE Khach='" + tendoiKhach.Text + "' AND Nha='" + tenDoiNha.Text + "'"
                 };
                for(int i = 0; i < up.Length; i++)
                {
                    sql.IUD(up[i]);
                }
                MessageBox.Show("Cập nhật");
                DataTable table = DataGrid.BangData("SELECT DsGhiban1,DsGhiban2 FROM TranDauTest") ;
                DataRow dataRow;
                for (int i = 0; i < 240; i++)
                {
                    dataRow = table.Rows[i];
                    stringghiban += dataRow[0].ToString() + dataRow[1].ToString();
                }
                string[] ten = new string[100];
                int[] soban = new int[100];
                int dem = 1;
                string[] tentmp = stringghiban.Split(',');
                ten[0] = tentmp[0];
                for (int i = 0; i < tentmp.Length - 1; i++)
                {
                    int demso = 0;
                    for (int j = 0; j < dem; j++)
                    {
                        if (tentmp[i] != ten[j])
                        {
                            demso++;
                        }
                        else if (tentmp[i] == ten[j])
                        {
                            soban[j]++;
                        }
                    }
                    if (demso == dem)
                    {
                        ten[dem] = tentmp[i];
                        soban[dem] = 1;
                        dem++;
                    }
                }
                string aa = "UPDATE DanSach SET  Ten=NULL, SoBanThang=NULL";
                sql.IUD(aa);
                for (int i = 0; i < dem; i++)
                {
                    sql.IUD("UPDATE DanSach SET  Ten='" + ten[i] + "', SoBanThang=" + soban[i] + " WHERE STT=" + (i + 1));
                    
                }
            }
        }
    }
}
