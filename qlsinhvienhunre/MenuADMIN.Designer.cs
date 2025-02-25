using System.Drawing.Drawing2D;

namespace QLSinhVienHunre
{
    partial class MenuADMIN
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconMenu = new System.Windows.Forms.PictureBox();
            this.logoHunre = new System.Windows.Forms.PictureBox();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btNganhHoc = new System.Windows.Forms.Button();
            this.btMonHoc = new System.Windows.Forms.Button();
            this.btLopHocPhan = new System.Windows.Forms.Button();
            this.btLop = new System.Windows.Forms.Button();
            this.btGiangVien = new System.Windows.Forms.Button();
            this.btSinhVien = new System.Windows.Forms.Button();
            this.btTaiKhoan = new System.Windows.Forms.Button();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHunre)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.iconMenu);
            this.panel2.Controls.Add(this.logoHunre);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 98);
            this.panel2.TabIndex = 5;
            // 
            // iconMenu
            // 
            this.iconMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconMenu.Image = global::QLSinhVienHunre.Properties.Resources.menu;
            this.iconMenu.Location = new System.Drawing.Point(20, 68);
            this.iconMenu.Name = "iconMenu";
            this.iconMenu.Size = new System.Drawing.Size(20, 21);
            this.iconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMenu.TabIndex = 8;
            this.iconMenu.TabStop = false;
            this.iconMenu.Click += new System.EventHandler(this.iconMenu_Click);
            // 
            // logoHunre
            // 
            this.logoHunre.BackColor = System.Drawing.Color.Transparent;
            this.logoHunre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoHunre.Image = global::QLSinhVienHunre.Properties.Resources.HUNRE_Logo;
            this.logoHunre.Location = new System.Drawing.Point(9, 9);
            this.logoHunre.Margin = new System.Windows.Forms.Padding(2);
            this.logoHunre.MaximumSize = new System.Drawing.Size(80, 80);
            this.logoHunre.MinimumSize = new System.Drawing.Size(48, 48);
            this.logoHunre.Name = "logoHunre";
            this.logoHunre.Size = new System.Drawing.Size(48, 48);
            this.logoHunre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoHunre.TabIndex = 7;
            this.logoHunre.TabStop = false;
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDangXuat.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDangXuat.Location = new System.Drawing.Point(926, 11);
            this.buttonDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(189, 39);
            this.buttonDangXuat.TabIndex = 2;
            this.buttonDangXuat.Text = "ĐĂNG XUẤT";
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(68, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1047, 476);
            this.panel3.TabIndex = 6;
            // 
            // sidebar
            // 
            this.sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.btNganhHoc);
            this.sidebar.Controls.Add(this.btMonHoc);
            this.sidebar.Controls.Add(this.btLopHocPhan);
            this.sidebar.Controls.Add(this.btLop);
            this.sidebar.Controls.Add(this.btGiangVien);
            this.sidebar.Controls.Add(this.btSinhVien);
            this.sidebar.Controls.Add(this.btTaiKhoan);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(191, 1000);
            this.sidebar.MinimumSize = new System.Drawing.Size(63, 1000);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(63, 1000);
            this.sidebar.TabIndex = 33;
            // 
            // btNganhHoc
            // 
            this.btNganhHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btNganhHoc.FlatAppearance.BorderSize = 0;
            this.btNganhHoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.btNganhHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNganhHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btNganhHoc.ForeColor = System.Drawing.Color.Transparent;
            this.btNganhHoc.Image = global::QLSinhVienHunre.Properties.Resources.library;
            this.btNganhHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNganhHoc.Location = new System.Drawing.Point(2, 104);
            this.btNganhHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btNganhHoc.Name = "btNganhHoc";
            this.btNganhHoc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btNganhHoc.Size = new System.Drawing.Size(189, 40);
            this.btNganhHoc.TabIndex = 33;
            this.btNganhHoc.Text = "     Ngành học";
            this.btNganhHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNganhHoc.UseVisualStyleBackColor = false;
            this.btNganhHoc.Click += new System.EventHandler(this.btNganhHoc_Click);
            // 
            // btMonHoc
            // 
            this.btMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btMonHoc.FlatAppearance.BorderSize = 0;
            this.btMonHoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.btMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btMonHoc.ForeColor = System.Drawing.Color.Transparent;
            this.btMonHoc.Image = global::QLSinhVienHunre.Properties.Resources.book;
            this.btMonHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMonHoc.Location = new System.Drawing.Point(2, 148);
            this.btMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btMonHoc.Name = "btMonHoc";
            this.btMonHoc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btMonHoc.Size = new System.Drawing.Size(189, 40);
            this.btMonHoc.TabIndex = 34;
            this.btMonHoc.Text = "     Môn học";
            this.btMonHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMonHoc.UseVisualStyleBackColor = false;
            this.btMonHoc.Click += new System.EventHandler(this.btMonHoc_Click);
            // 
            // btLopHocPhan
            // 
            this.btLopHocPhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btLopHocPhan.FlatAppearance.BorderSize = 0;
            this.btLopHocPhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.btLopHocPhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLopHocPhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btLopHocPhan.ForeColor = System.Drawing.Color.Transparent;
            this.btLopHocPhan.Image = global::QLSinhVienHunre.Properties.Resources.globe;
            this.btLopHocPhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLopHocPhan.Location = new System.Drawing.Point(2, 192);
            this.btLopHocPhan.Margin = new System.Windows.Forms.Padding(2);
            this.btLopHocPhan.Name = "btLopHocPhan";
            this.btLopHocPhan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btLopHocPhan.Size = new System.Drawing.Size(189, 40);
            this.btLopHocPhan.TabIndex = 35;
            this.btLopHocPhan.Text = "     Lớp học phần";
            this.btLopHocPhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLopHocPhan.UseVisualStyleBackColor = false;
            this.btLopHocPhan.Click += new System.EventHandler(this.btLopHocPhan_Click);
            // 
            // btLop
            // 
            this.btLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btLop.FlatAppearance.BorderSize = 0;
            this.btLop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.btLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btLop.ForeColor = System.Drawing.Color.Transparent;
            this.btLop.Image = global::QLSinhVienHunre.Properties.Resources._class;
            this.btLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLop.Location = new System.Drawing.Point(2, 236);
            this.btLop.Margin = new System.Windows.Forms.Padding(2);
            this.btLop.Name = "btLop";
            this.btLop.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btLop.Size = new System.Drawing.Size(189, 40);
            this.btLop.TabIndex = 36;
            this.btLop.Text = "     Lớp";
            this.btLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLop.UseVisualStyleBackColor = false;
            this.btLop.Click += new System.EventHandler(this.btLop_Click);
            // 
            // btGiangVien
            // 
            this.btGiangVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btGiangVien.FlatAppearance.BorderSize = 0;
            this.btGiangVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.btGiangVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGiangVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btGiangVien.ForeColor = System.Drawing.Color.Transparent;
            this.btGiangVien.Image = global::QLSinhVienHunre.Properties.Resources.blackboard;
            this.btGiangVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGiangVien.Location = new System.Drawing.Point(2, 280);
            this.btGiangVien.Margin = new System.Windows.Forms.Padding(2);
            this.btGiangVien.Name = "btGiangVien";
            this.btGiangVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btGiangVien.Size = new System.Drawing.Size(189, 40);
            this.btGiangVien.TabIndex = 37;
            this.btGiangVien.Text = "     Giảng viên";
            this.btGiangVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGiangVien.UseVisualStyleBackColor = false;
            this.btGiangVien.Click += new System.EventHandler(this.btGiangVien_Click);
            // 
            // btSinhVien
            // 
            this.btSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btSinhVien.FlatAppearance.BorderSize = 0;
            this.btSinhVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.btSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btSinhVien.ForeColor = System.Drawing.Color.Transparent;
            this.btSinhVien.Image = global::QLSinhVienHunre.Properties.Resources.graduation;
            this.btSinhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSinhVien.Location = new System.Drawing.Point(2, 324);
            this.btSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.btSinhVien.Name = "btSinhVien";
            this.btSinhVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btSinhVien.Size = new System.Drawing.Size(189, 40);
            this.btSinhVien.TabIndex = 38;
            this.btSinhVien.Text = "     Sinh viên";
            this.btSinhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSinhVien.UseVisualStyleBackColor = false;
            this.btSinhVien.UseWaitCursor = true;
            this.btSinhVien.Click += new System.EventHandler(this.btSinhVien_Click);
            // 
            // btTaiKhoan
            // 
            this.btTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.btTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.btTaiKhoan.Image = global::QLSinhVienHunre.Properties.Resources.account;
            this.btTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaiKhoan.Location = new System.Drawing.Point(2, 368);
            this.btTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btTaiKhoan.Name = "btTaiKhoan";
            this.btTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btTaiKhoan.Size = new System.Drawing.Size(189, 40);
            this.btTaiKhoan.TabIndex = 39;
            this.btTaiKhoan.Text = "     Tài khoản";
            this.btTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTaiKhoan.UseVisualStyleBackColor = false;
            this.btTaiKhoan.Click += new System.EventHandler(this.btTaiKhoan_Click);
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 1;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // MenuADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::QLSinhVienHunre.Properties.Resources.bg_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 538);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonDangXuat);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Resize += new System.EventHandler(this.MenuADMIN_Resize);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHunre)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDangXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logoHunre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox iconMenu;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btTaiKhoan;
        private System.Windows.Forms.Button btSinhVien;
        private System.Windows.Forms.Button btGiangVien;
        private System.Windows.Forms.Button btLop;
        private System.Windows.Forms.Button btLopHocPhan;
        private System.Windows.Forms.Button btMonHoc;
        private System.Windows.Forms.Button btNganhHoc;
        private System.Windows.Forms.Timer sidebartimer;
    }
}

