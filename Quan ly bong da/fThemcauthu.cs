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
using System.IO;

namespace Quan_ly_bong_da
{
    public partial class fThemcauthu : Form
    {
        public fThemcauthu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txbid.Text != null && txbid.Text != "")
            {
                try
                {
                    string Img = "\\Images\\" + txbid.Text + ".jpg";
                    string query = "INSERT INTO CAUTHU VALUES ('" + txbid.Text + "','" + TBTEN.Text + "','" + tbclb.Text +
                        "','" + dateNgaySinh.Text + "','" + cbvitri.Text + "','" + tbquocgia.Text + "','" + Img + "')";
                    sql.IUD(query);
                    MessageBox.Show("Thêm thành công");
                    txbid.Text = "";TBTEN.Text = "";tbclb.Text="";cbvitri.Text = "";tbquocgia.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "JPG|*.jpg|PNG|*.png|ALL FILE|*.*";
                if (txbid.Text != "" && txbid.Text != null)
                {
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        if (open.CheckFileExists)
                        {
                            piccauthu.Image = System.Drawing.Image.FromFile(open.FileName);
                            File.Copy(open.FileName, Bien.path + "\\Images\\" + txbid.Text+ ".jpg", true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
