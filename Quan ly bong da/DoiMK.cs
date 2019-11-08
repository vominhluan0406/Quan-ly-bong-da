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
    public partial class DoiMK : Form
    {
        public DoiMK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkdung.Visible == true && checkMKDUNG.Visible == true)
            {
                string query = "UPDATE LogIn SET Password ='"+mkmoi.Text+"' WHERE Username='"+Bien.user+"'";
                sql.IUD(query);
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập mật khẩu sai");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (mkmoi.Text != mkmoilai.Text)
            {
                checknhaplai.Visible = true;
                checkdung.Visible = false;
            }
            if (mkmoi.Text == mkmoilai.Text)
            {
                checknhaplai.Visible = false;
                checkdung.Visible = true;
            }
        }

        private void DoiMK_Load(object sender, EventArgs e)
        {
            checknhaplai.Visible = false;
            checkdung.Visible = false;
            checkMK.Visible = false;
            checkMKDUNG.Visible = false;
            username.Text = Bien.user;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            string query = "SELECT Password FROM LogIn WHERE Username ='"+username.Text+"'";
            DataTable dt = DataGrid.BangData(query);
            DataRow r = dt.Rows[0];
            if (tbpass.Text != r[0].ToString())
            {
                checkMK.Visible = true;
                checkMKDUNG.Visible = false;
            }
            if(tbpass.Text == r[0].ToString()){
                checkMK.Visible = false;
                checkMKDUNG.Visible = true;
            }
        }
    }
}
