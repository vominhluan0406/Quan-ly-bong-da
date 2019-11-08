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
    public partial class fLogin : Form
    {
        SQLiteConnection con = Connect.getCon();
        SQLiteCommand cmd = new SQLiteCommand();
        fMain f = new fMain();
        public fLogin()
        {
            InitializeComponent();
        }
        int x, y, move=0;

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if(user.Text=="Tên đăng nhập")
            {
                user.Text = "";
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "Tên đăng nhập";
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Mật khẩu";
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if(password.Text != "")
            {
                password.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string users = user.Text;
            string pass = password.Text;
            try {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM  Login WHERE Username='" + users + "' AND Password='" + pass + "'";
                cmd.ExecuteNonQuery();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int number = dt.Rows.Count;
                if (number == 0)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
                else
                {
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            x = e.X;
            y = e.Y;
        }
    }
}
