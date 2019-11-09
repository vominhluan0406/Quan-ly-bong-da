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

namespace Quan_ly_bong_da
{
    public partial class fMain : Form
    {
        int x, y, move;
        string path = Bien.path;
        fThongtinCLB fthonftin = new fThongtinCLB();
        public fMain()
        {
            InitializeComponent();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
        public void fMain_Load(object sender, EventArgs e)
        {
            cbChon.Text = "Bảng xếp hạng";
            time.Text = DateTime.Now.ToLongTimeString();
            pnLichthidau.Visible = false;
            string[] query = { "SELECT Img FROM CAULACBO ORDER BY Diem Desc" };
            DataTable dt = DataGrid.BangData(query[0]);
            DataRow row;
            PictureBox[] pic = { doi1, doi2, doi3, doi4, doi5, doi6, doi7, doi8, doi9, doi10, doi11, doi12, doi13, doi14, doi15, doi16 };
            for (int i = 0; i < 16; i++)
            {
                row = dt.Rows[i];
                pic[i].Image = new Bitmap(path+row[0].ToString());
            }
            DataTable da = DataGrid.BangData("SELECT TenCLB FROM CAULACBO");
            cbCLB.DataSource = da;
            cbCLB.DisplayMember = "TenCLB";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] query = { "SELECT TenCLB as 'Câu lạc bộ',Diem as 'Điểm',HieuSo as 'Hệ số' FROM CAULACBO ORDER BY Diem DESC,HieuSo DESC",
                                          "SELECT Ten as 'Cầu thủ',SoBanThang as 'Bàn thắng' FROM DanSach ORDER BY SoBanThang DESC",
                                          "SELECT Nha as 'Đội nhà',a as'Home',b as'Away',Khach as 'Đội khách' FROM TranDauTest"

            };
            if(cbChon.Text.ToString()=="Bảng xếp hạng")
            {
                bangData.DataSource = DataGrid.BangData(query[0]);
                pnLichthidau.Visible = false;
            }
            if (cbChon.Text.ToString() == "Thống kê")
            {
                bangData.DataSource = DataGrid.BangData(query[1]);
                pnLichthidau.Visible = false;
            }
            if (cbChon.Text.ToString() == "Lịch thi đấu")
            {

                bangData.DataSource = DataGrid.BangData(query[2]);
                pnLichthidau.Visible = true;
            }
            bangData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void bangData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bangData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null&& cbChon.Text.ToString() == "Lịch thi đấu")
            {
                bangData.CurrentRow.Selected = true;
                DataGridViewRow data = new DataGridViewRow();
                data = bangData.Rows[e.RowIndex];
                Bien.IDNha = data.Cells[0].Value.ToString();
                Bien.IDKhach = data.Cells[3].Value.ToString();
                CapnhatKQ f = new CapnhatKQ();
                f.ShowDialog();
            }
        }

        private void doi1_Click(object sender, EventArgs e)
        {
            Bien.ID = 0;
            fthonftin.ShowDialog();
        }

        private void doi5_Click(object sender, EventArgs e)
        {
            Bien.ID = 4;
            fthonftin.ShowDialog();
        }

        private void doi2_Click(object sender, EventArgs e)
        {
            Bien.ID = 1;
            fthonftin.ShowDialog();
        }

        private void doi11_Click(object sender, EventArgs e)
        {
            Bien.ID = 10;
            fthonftin.ShowDialog();
        }

        private void doi3_Click(object sender, EventArgs e)
        {
            Bien.ID = 2;
            fthonftin.ShowDialog();
        }

        private void doi10_Click(object sender, EventArgs e)
        {
            Bien.ID = 9;
            fthonftin.ShowDialog();
        }

        private void doi6_Click(object sender, EventArgs e)
        {
            Bien.ID = 5;
            fthonftin.ShowDialog();
        }

        private void doi8_Click(object sender, EventArgs e)
        {
            Bien.ID = 7;
            fthonftin.ShowDialog();
        }

        private void doi13_Click(object sender, EventArgs e)
        {
            Bien.ID = 12;
            fthonftin.ShowDialog();
        }

        private void doi16_Click(object sender, EventArgs e)
        {
            Bien.ID = 15;
            fthonftin.ShowDialog();
        }

        private void doi12_Click(object sender, EventArgs e)
        {
            Bien.ID = 11;
            fthonftin.ShowDialog();
        }

        private void doi15_Click(object sender, EventArgs e)
        {
            Bien.ID = 14;
            fthonftin.ShowDialog();
        }

        private void doi7_Click(object sender, EventArgs e)
        {
            Bien.ID = 6;
            fthonftin.ShowDialog();
        }

        private void doi4_Click(object sender, EventArgs e)
        {
            Bien.ID = 3;
            fthonftin.ShowDialog();
        }

        private void doi9_Click(object sender, EventArgs e)
        {
            Bien.ID = 8;
            fthonftin.ShowDialog();
        }

        private void doi14_Click(object sender, EventArgs e)
        {
            Bien.ID = 13;
            fthonftin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tạo mới giải đấu?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                loadingTao f = new loadingTao();
                f.ShowDialog();
                MessageBox.Show("Tạo thành công");
                fMain_Load(sender, e);
                cbChon_SelectedIndexChanged(sender, e);
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "select ID,Ten,CLB,QuocGia,NgaySinh,ViTri,Img from CAUTHU where Ten like '%" + tbTenSearch.Text + "%' and CLB like '%" + cbCLB.Text+ "%' and ViTri like '%"+cbvitri.Text+"%'";
            DataTable dt = DataGrid.BangData(query);
            dataCauthu.DataSource = dt;
            dataCauthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCauthu.Columns[0].HeaderText = "ID";
            dataCauthu.Columns[1].HeaderText = "Tên";
            dataCauthu.Columns[2].HeaderText = "Câu lạc bộ";
            dataCauthu.Columns[3].HeaderText = "Quốc gia";
            dataCauthu.Columns[4].HeaderText = "Ngày sinh";
            dataCauthu.Columns[5].HeaderText = "Vị trí";
            dataCauthu.Columns[6].Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataCauthu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            piccauthu.Image = null;
            try
            {
                if (dataCauthu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataCauthu.CurrentRow.Selected = true;
                    piccauthu.Image = null;
                    DataGridViewRow row = new DataGridViewRow();
                    row = dataCauthu.Rows[e.RowIndex];
                    txbid.Text = row.Cells[0].Value.ToString();
                    txbname.Text = row.Cells[1].Value.ToString();
                    txbclb.Text = row.Cells[2].Value.ToString();
                    txbquochia.Text = row.Cells[3].Value.ToString();
                    dateNgaySinh.Text = row.Cells[4].Value.ToString();
                    txbvitri.Text = row.Cells[5].Value.ToString();
                    piccauthu.Image = Image.image(row.Cells[6].Value.ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fThemcauthu f = new fThemcauthu();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query="DELETE FROM CAUTHU WHERE ID='"+txbid.Text+"'";
            try
            {
                if (txbid.Text != null && txbid.Text != "")
                {
                    if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        sql.IUD(query);
                        MessageBox.Show("Đã xóa");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "UPDATE CAUTHU SET Ten='"+txbname.Text+"', CLB='"+txbclb.Text+"', NgaySinh='"+dateNgaySinh.Text+
                "',Vitri='"+txbvitri.Text+"',QuocGia='"+txbquochia.Text+"' WHERE ID='"+txbid.Text+"'";
            try
            {
                if (txbid.Text != null && txbid.Text != "")
                {
                        sql.IUD(query);
                        MessageBox.Show("Cập nhật thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void piccauthu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thay đổi ảnh cầu thủ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
                                File.Copy(open.FileName, Bien.path + "\\Images\\" + txbid.Text + ".jpg", true);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Nha as 'Đội nhà',a as'Home',b as'Away',Khach as 'Đội khách' FROM TranDauTest,LichThiDauTest WHERE IDVong ='" + tbVong.Text +
                   "' and (IDTran=Tran1 or IDTran=Tran2  or IDTran=Tran3  or IDTran=Tran4  or IDTran=Tran5 or IDTran=Tran6 or IDTran=Tran7 or IDTran=Tran8)";
                bangData.DataSource = DataGrid.BangData(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMK f = new DoiMK();
            f.ShowDialog();
        }

        private void tabControl2_Click(object sender, EventArgs e)
        {
            fMain_Load(sender, e);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void đăngXuãtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
