namespace Quan_ly_bong_da
{
    partial class fLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.TextBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(172)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dangnhap);
            this.panel1.Controls.Add(this.thoat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 438);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.password);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(139, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 42);
            this.panel4.TabIndex = 8;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(37, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(278, 38);
            this.password.TabIndex = 4;
            this.password.Text = "Mật khẩu";
            this.password.UseSystemPasswordChar = true;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Quan_ly_bong_da.Properties.Resources.pass;
            this.pictureBox2.Location = new System.Drawing.Point(0, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.user);
            this.panel3.Location = new System.Drawing.Point(139, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 39);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quan_ly_bong_da.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(37, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(277, 38);
            this.user.TabIndex = 3;
            this.user.Text = "Tên đăng nhập";
            this.user.Enter += new System.EventHandler(this.user_Enter);
            this.user.Leave += new System.EventHandler(this.user_Leave);
            // 
            // dangnhap
            // 
            this.dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(94)))));
            this.dangnhap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(94)))));
            this.dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.ForeColor = System.Drawing.Color.Transparent;
            this.dangnhap.Location = new System.Drawing.Point(71, 372);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(184, 63);
            this.dangnhap.TabIndex = 2;
            this.dangnhap.Text = "Đăng nhập";
            this.dangnhap.UseVisualStyleBackColor = false;
            this.dangnhap.Click += new System.EventHandler(this.button2_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(94)))));
            this.thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(94)))));
            this.thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.ForeColor = System.Drawing.Color.Transparent;
            this.thoat.Location = new System.Drawing.Point(362, 372);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(184, 63);
            this.thoat.TabIndex = 1;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 63);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình quản lý giải bóng đá";
            // 
            // fLogin
            // 
            this.AcceptButton = this.dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.thoat;
            this.ClientSize = new System.Drawing.Size(588, 435);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLogin";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
    }
}