using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Quan_ly_bong_da
{
    public partial class CapnhatCLB : Form
    {
        string st1 = null;
        string st2 = null;
        string st3 = null;
        string st4 = null;
        public CapnhatCLB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string Open(string to,PictureBox s)
        {
            string ss = null;
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "JPG|*.jpg|PNG|*.png|ALL FILE|*.*";
                if (tbID.Text != "" && tbID.Text != null)
                {
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        if (open.CheckFileExists)
                        {
                           
                            s.Image =System.Drawing.Image.FromFile(open.FileName);
                            File.Copy(open.FileName, Bien.path + "\\Images\\" + tbID.Text+to+ ".jpg", true);
                            ss = "\\Images\\" + tbID.Text + to + ".jpg";
                        }
                    }
                }
                return ss;
            }
            catch (Exception ex)
            {
                return ss;
            }
        }
        private void openNha_Click(object sender, EventArgs e)
        {
           st1= Open("_home", anhNha);
        }

        private void openKhach_Click(object sender, EventArgs e)
        {
            st2=Open("_away", anhKhach);
        }
        private void openLogo_Click(object sender, EventArgs e)
        {
            st3=Open("", anhLogo);
        }

        private void openSVD_Click(object sender, EventArgs e)
        {
           st4= Open("_hlv", anhVD);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE CAULACBO SET ID='" + tbID.Text + "',TenCLB='" + tbTenCLB.Text + "',HLV='" + tbhlv.Text +
                    "',NamThanhLap='" + tbnam.Text + "',SVD='" + tbSVD.Text + "',Img='" + st3 + "', ImgHVL='" + st4 + "',ImgAoNha='" + st1 + "',ImgAoKhach='"
                    + st2 + "' WHERE ID='" + Bien.IDCLB + "'";
                sql.IUD(query);
                MessageBox.Show("Thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi :"+ex.Message.ToString());
            }
        }

        private void CapnhatCLB_Load(object sender, EventArgs e)
        {
            st1 = "\\Images\\" + Bien.IDCLB + "_home.jpg";
            st2 = "\\Images\\" + Bien.IDCLB + "_away.jpg";
            st3 = "\\Images\\" + Bien.IDCLB + ".jpg";
            st4 = "\\Images\\" + Bien.IDCLB + "_hlv.jpg";
        }
    }
}
