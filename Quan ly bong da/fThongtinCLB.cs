using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Quan_ly_bong_da
{
    public partial class fThongtinCLB : Form
    {
        string tmp = null;
        public fThongtinCLB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fThongtinCLB_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DataGrid.BangData("Select TenCLB,HLV,NamThanhLap,SVD,Img,ImgAoNha,ImgAoKhach,ImgHVL,ID from CAULACBO WHERE ID='" + DataGrid.returnID(Bien.ID) + "'");
                DataRow row;
                row = dt.Rows[0];
                lbCLB.Text = row[0].ToString();
                namthanhlap.Text = "Năm thành lập " + row[2].ToString();
                tenhlv.Text = "Huấn luyện viên " + row[1].ToString();
                svdlb.Text = "Sân vận động " + row[3].ToString();
                picCLB.Image = Image.image(row[4].ToString());
                picNha.Image = Image.image(row[5].ToString());
                pickhach.Image = Image.image(row[6].ToString());
                anhSVD.Image = Image.image(row[7].ToString());
                Bien.IDCLB = row[8].ToString();
                tmp= row[8].ToString(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CapnhatCLB f = new CapnhatCLB();
            Bien.IDCLB = tmp;
            f.ShowDialog();
        }
    }
}
