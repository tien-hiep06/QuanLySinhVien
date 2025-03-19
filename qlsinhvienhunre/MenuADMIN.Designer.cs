using quanlisinhvienHUNRE;
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.iconMenu = new System.Windows.Forms.PictureBox();
            this.logoHunre = new System.Windows.Forms.PictureBox();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnNganhHoc = new System.Windows.Forms.Panel();
            this.btNganhHoc = new System.Windows.Forms.Button();
            this.pnLopHocPhan = new System.Windows.Forms.Panel();
            this.btLopHocPhan = new System.Windows.Forms.Button();
            this.pnMonHoc = new System.Windows.Forms.Panel();
            this.btMonHoc = new System.Windows.Forms.Button();
            this.pnLop = new System.Windows.Forms.Panel();
            this.btLop = new System.Windows.Forms.Button();
            this.pnGiangVien = new System.Windows.Forms.Panel();
            this.btGiangVien = new System.Windows.Forms.Button();
            this.pnSinhVien = new System.Windows.Forms.Panel();
            this.btSinhVien = new System.Windows.Forms.Button();
            this.pnTaiKhoan = new System.Windows.Forms.Panel();
            this.btTaiKhoan = new System.Windows.Forms.Button();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.pnDangXuat = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHunre)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnNganhHoc.SuspendLayout();
            this.pnLopHocPhan.SuspendLayout();
            this.pnMonHoc.SuspendLayout();
            this.pnLop.SuspendLayout();
            this.pnGiangVien.SuspendLayout();
            this.pnSinhVien.SuspendLayout();
            this.pnTaiKhoan.SuspendLayout();
            this.pnDangXuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMenu.Controls.Add(this.iconMenu);
            this.pnMenu.Controls.Add(this.logoHunre);
            this.pnMenu.Location = new System.Drawing.Point(2, 2);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(189, 98);
            this.pnMenu.TabIndex = 5;
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
            // btDangXuat
            // 
            this.btDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btDangXuat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDangXuat.ForeColor = System.Drawing.Color.Transparent;
            this.btDangXuat.Location = new System.Drawing.Point(-7, -4);
            this.btDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(204, 47);
            this.btDangXuat.TabIndex = 2;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.UseVisualStyleBackColor = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Location = new System.Drawing.Point(68, 51);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(719, 425);
            this.pnMain.TabIndex = 6;
            // 
            // sidebar
            // 
            this.sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.sidebar.Controls.Add(this.pnMenu);
            this.sidebar.Controls.Add(this.pnNganhHoc);
            this.sidebar.Controls.Add(this.pnLopHocPhan);
            this.sidebar.Controls.Add(this.pnMonHoc);
            this.sidebar.Controls.Add(this.pnLop);
            this.sidebar.Controls.Add(this.pnGiangVien);
            this.sidebar.Controls.Add(this.pnSinhVien);
            this.sidebar.Controls.Add(this.pnTaiKhoan);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(191, 1000);
            this.sidebar.MinimumSize = new System.Drawing.Size(63, 1000);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(63, 1000);
            this.sidebar.TabIndex = 33;
            // 
            // pnNganhHoc
            // 
            this.pnNganhHoc.Controls.Add(this.btNganhHoc);
            this.pnNganhHoc.Location = new System.Drawing.Point(3, 105);
            this.pnNganhHoc.Name = "pnNganhHoc";
            this.pnNganhHoc.Size = new System.Drawing.Size(189, 40);
            this.pnNganhHoc.TabIndex = 35;
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
            this.btNganhHoc.Location = new System.Drawing.Point(0, 0);
            this.btNganhHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btNganhHoc.Name = "btNganhHoc";
            this.btNganhHoc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btNganhHoc.Size = new System.Drawing.Size(189, 40);
            this.btNganhHoc.TabIndex = 33;
            this.btNganhHoc.Text = "     Ngành học";
            this.btNganhHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNganhHoc.UseVisualStyleBackColor = false;
            this.btNganhHoc.Click += new System.EventHandler(this.btChildForm_Click);
            // 
            // pnLopHocPhan
            // 
            this.pnLopHocPhan.Controls.Add(this.btLopHocPhan);
            this.pnLopHocPhan.Location = new System.Drawing.Point(3, 151);
            this.pnLopHocPhan.Name = "pnLopHocPhan";
            this.pnLopHocPhan.Size = new System.Drawing.Size(189, 40);
            this.pnLopHocPhan.TabIndex = 35;
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
            this.btLopHocPhan.Location = new System.Drawing.Point(0, 0);
            this.btLopHocPhan.Margin = new System.Windows.Forms.Padding(2);
            this.btLopHocPhan.Name = "btLopHocPhan";
            this.btLopHocPhan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btLopHocPhan.Size = new System.Drawing.Size(189, 40);
            this.btLopHocPhan.TabIndex = 35;
            this.btLopHocPhan.Text = "     Lớp học phần";
            this.btLopHocPhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLopHocPhan.UseVisualStyleBackColor = false;
            this.btLopHocPhan.Click += new System.EventHandler(this.btChildForm_Click);
            // 
            // pnMonHoc
            // 
            this.pnMonHoc.Controls.Add(this.btMonHoc);
            this.pnMonHoc.Location = new System.Drawing.Point(3, 197);
            this.pnMonHoc.Name = "pnMonHoc";
            this.pnMonHoc.Size = new System.Drawing.Size(189, 40);
            this.pnMonHoc.TabIndex = 35;
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
            this.btMonHoc.Location = new System.Drawing.Point(0, 0);
            this.btMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btMonHoc.Name = "btMonHoc";
            this.btMonHoc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btMonHoc.Size = new System.Drawing.Size(189, 40);
            this.btMonHoc.TabIndex = 34;
            this.btMonHoc.Text = "     Môn học";
            this.btMonHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMonHoc.UseVisualStyleBackColor = false;
            this.btMonHoc.Click += new System.EventHandler(this.btChildForm_Click);
            // 
            // pnLop
            // 
            this.pnLop.Controls.Add(this.btLop);
            this.pnLop.Location = new System.Drawing.Point(3, 243);
            this.pnLop.Name = "pnLop";
            this.pnLop.Size = new System.Drawing.Size(189, 40);
            this.pnLop.TabIndex = 35;
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
            this.btLop.Location = new System.Drawing.Point(0, 0);
            this.btLop.Margin = new System.Windows.Forms.Padding(2);
            this.btLop.Name = "btLop";
            this.btLop.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btLop.Size = new System.Drawing.Size(189, 40);
            this.btLop.TabIndex = 36;
            this.btLop.Text = "     Lớp";
            this.btLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLop.UseVisualStyleBackColor = false;
            this.btLop.Click += new System.EventHandler(this.btChildForm_Click);
            // 
            // pnGiangVien
            // 
            this.pnGiangVien.Controls.Add(this.btGiangVien);
            this.pnGiangVien.Location = new System.Drawing.Point(3, 289);
            this.pnGiangVien.Name = "pnGiangVien";
            this.pnGiangVien.Size = new System.Drawing.Size(189, 40);
            this.pnGiangVien.TabIndex = 34;
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
            this.btGiangVien.Location = new System.Drawing.Point(0, 0);
            this.btGiangVien.Margin = new System.Windows.Forms.Padding(2);
            this.btGiangVien.Name = "btGiangVien";
            this.btGiangVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btGiangVien.Size = new System.Drawing.Size(189, 40);
            this.btGiangVien.TabIndex = 37;
            this.btGiangVien.Text = "     Giảng viên";
            this.btGiangVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGiangVien.UseVisualStyleBackColor = false;
            this.btGiangVien.Click += new System.EventHandler(this.btChildForm_Click);
            // 
            // pnSinhVien
            // 
            this.pnSinhVien.Controls.Add(this.btSinhVien);
            this.pnSinhVien.Location = new System.Drawing.Point(3, 335);
            this.pnSinhVien.Name = "pnSinhVien";
            this.pnSinhVien.Size = new System.Drawing.Size(189, 40);
            this.pnSinhVien.TabIndex = 35;
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
            this.btSinhVien.Location = new System.Drawing.Point(0, 0);
            this.btSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.btSinhVien.Name = "btSinhVien";
            this.btSinhVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btSinhVien.Size = new System.Drawing.Size(189, 40);
            this.btSinhVien.TabIndex = 38;
            this.btSinhVien.Text = "     Sinh viên";
            this.btSinhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSinhVien.UseVisualStyleBackColor = false;
            this.btSinhVien.UseWaitCursor = true;
            this.btSinhVien.Click += new System.EventHandler(this.btChildForm_Click);
            // 
            // pnTaiKhoan
            // 
            this.pnTaiKhoan.Controls.Add(this.btTaiKhoan);
            this.pnTaiKhoan.Location = new System.Drawing.Point(3, 381);
            this.pnTaiKhoan.Name = "pnTaiKhoan";
            this.pnTaiKhoan.Size = new System.Drawing.Size(189, 40);
            this.pnTaiKhoan.TabIndex = 35;
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
            this.btTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.btTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btTaiKhoan.Name = "btTaiKhoan";
            this.btTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btTaiKhoan.Size = new System.Drawing.Size(189, 40);
            this.btTaiKhoan.TabIndex = 39;
            this.btTaiKhoan.Text = "     Tài khoản";
            this.btTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 1;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // pnDangXuat
            // 
            this.pnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDangXuat.Controls.Add(this.btDangXuat);
            this.pnDangXuat.Location = new System.Drawing.Point(598, 7);
            this.pnDangXuat.Name = "pnDangXuat";
            this.pnDangXuat.Size = new System.Drawing.Size(189, 39);
            this.pnDangXuat.TabIndex = 37;
            // 
            // MenuADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::QLSinhVienHunre.Properties.Resources.bg_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 487);
            this.Controls.Add(this.pnDangXuat);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnMain);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(814, 526);
            this.Name = "MenuADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Resize += new System.EventHandler(this.MenuADMIN_Resize);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHunre)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnNganhHoc.ResumeLayout(false);
            this.pnLopHocPhan.ResumeLayout(false);
            this.pnMonHoc.ResumeLayout(false);
            this.pnLop.ResumeLayout(false);
            this.pnGiangVien.ResumeLayout(false);
            this.pnSinhVien.ResumeLayout(false);
            this.pnTaiKhoan.ResumeLayout(false);
            this.pnDangXuat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.PictureBox logoHunre;
        private System.Windows.Forms.Panel pnMain;
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
        private System.Windows.Forms.Panel pnGiangVien;
        private System.Windows.Forms.Panel pnSinhVien;
        private System.Windows.Forms.Panel pnLop;
        private System.Windows.Forms.Panel pnMonHoc;
        private System.Windows.Forms.Panel pnTaiKhoan;
        private System.Windows.Forms.Panel pnNganhHoc;
        private System.Windows.Forms.Panel pnLopHocPhan;
        private System.Windows.Forms.Panel pnDangXuat;
    }
}

