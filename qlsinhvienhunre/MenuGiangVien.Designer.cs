namespace QLSinhVienHunre
{
    partial class MenuGiangVien
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
            this.pnDangXuat = new System.Windows.Forms.Panel();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.iconMenu = new System.Windows.Forms.PictureBox();
            this.logoHunre = new System.Windows.Forms.PictureBox();
            this.btTaiKhoan = new System.Windows.Forms.Button();
            this.btLopHoc = new System.Windows.Forms.Button();
            this.pnKetQuaHocPhan = new System.Windows.Forms.Panel();
            this.btKetQuaHocPhan = new System.Windows.Forms.Button();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.pnLopHoc = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTaiKhoan = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDangXuat.SuspendLayout();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHunre)).BeginInit();
            this.pnKetQuaHocPhan.SuspendLayout();
            this.pnLopHoc.SuspendLayout();
            this.pnTaiKhoan.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDangXuat
            // 
            this.pnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDangXuat.Controls.Add(this.btDangXuat);
            this.pnDangXuat.Location = new System.Drawing.Point(693, 7);
            this.pnDangXuat.Name = "pnDangXuat";
            this.pnDangXuat.Size = new System.Drawing.Size(189, 39);
            this.pnDangXuat.TabIndex = 40;
            // 
            // btDangXuat
            // 
            this.btDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDangXuat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDangXuat.ForeColor = System.Drawing.Color.Transparent;
            this.btDangXuat.Location = new System.Drawing.Point(-12, -3);
            this.btDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(211, 47);
            this.btDangXuat.TabIndex = 2;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.UseVisualStyleBackColor = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
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
            this.btTaiKhoan.Location = new System.Drawing.Point(-1, 0);
            this.btTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btTaiKhoan.Name = "btTaiKhoan";
            this.btTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btTaiKhoan.Size = new System.Drawing.Size(189, 40);
            this.btTaiKhoan.TabIndex = 39;
            this.btTaiKhoan.Text = "     Tài khoản";
            this.btTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btLopHoc
            // 
            this.btLopHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btLopHoc.FlatAppearance.BorderSize = 0;
            this.btLopHoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.btLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btLopHoc.ForeColor = System.Drawing.Color.Transparent;
            this.btLopHoc.Image = global::QLSinhVienHunre.Properties.Resources._class;
            this.btLopHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLopHoc.Location = new System.Drawing.Point(-1, 0);
            this.btLopHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btLopHoc.Name = "btLopHoc";
            this.btLopHoc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btLopHoc.Size = new System.Drawing.Size(189, 40);
            this.btLopHoc.TabIndex = 36;
            this.btLopHoc.Text = "     Lớp học";
            this.btLopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLopHoc.UseVisualStyleBackColor = false;
            // 
            // pnKetQuaHocPhan
            // 
            this.pnKetQuaHocPhan.Controls.Add(this.btKetQuaHocPhan);
            this.pnKetQuaHocPhan.Location = new System.Drawing.Point(3, 105);
            this.pnKetQuaHocPhan.Name = "pnKetQuaHocPhan";
            this.pnKetQuaHocPhan.Size = new System.Drawing.Size(189, 40);
            this.pnKetQuaHocPhan.TabIndex = 35;
            // 
            // btKetQuaHocPhan
            // 
            this.btKetQuaHocPhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btKetQuaHocPhan.FlatAppearance.BorderSize = 0;
            this.btKetQuaHocPhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.btKetQuaHocPhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKetQuaHocPhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btKetQuaHocPhan.ForeColor = System.Drawing.Color.Transparent;
            this.btKetQuaHocPhan.Image = global::QLSinhVienHunre.Properties.Resources.globe;
            this.btKetQuaHocPhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKetQuaHocPhan.Location = new System.Drawing.Point(0, 0);
            this.btKetQuaHocPhan.Margin = new System.Windows.Forms.Padding(2);
            this.btKetQuaHocPhan.Name = "btKetQuaHocPhan";
            this.btKetQuaHocPhan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btKetQuaHocPhan.Size = new System.Drawing.Size(189, 40);
            this.btKetQuaHocPhan.TabIndex = 35;
            this.btKetQuaHocPhan.Text = "     Kết quả học phần";
            this.btKetQuaHocPhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btKetQuaHocPhan.UseVisualStyleBackColor = false;
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 1;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // pnLopHoc
            // 
            this.pnLopHoc.Controls.Add(this.btLopHoc);
            this.pnLopHoc.Location = new System.Drawing.Point(3, 151);
            this.pnLopHoc.Name = "pnLopHoc";
            this.pnLopHoc.Size = new System.Drawing.Size(189, 40);
            this.pnLopHoc.TabIndex = 35;
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Location = new System.Drawing.Point(68, 52);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(814, 555);
            this.pnMain.TabIndex = 38;
            // 
            // pnTaiKhoan
            // 
            this.pnTaiKhoan.Controls.Add(this.btTaiKhoan);
            this.pnTaiKhoan.Location = new System.Drawing.Point(3, 197);
            this.pnTaiKhoan.Name = "pnTaiKhoan";
            this.pnTaiKhoan.Size = new System.Drawing.Size(189, 40);
            this.pnTaiKhoan.TabIndex = 35;
            // 
            // sidebar
            // 
            this.sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.sidebar.Controls.Add(this.pnMenu);
            this.sidebar.Controls.Add(this.pnKetQuaHocPhan);
            this.sidebar.Controls.Add(this.pnLopHoc);
            this.sidebar.Controls.Add(this.pnTaiKhoan);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(191, 1000);
            this.sidebar.MinimumSize = new System.Drawing.Size(63, 1000);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(63, 1000);
            this.sidebar.TabIndex = 39;
            // 
            // MenuGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSinhVienHunre.Properties.Resources.bg_login;
            this.ClientSize = new System.Drawing.Size(893, 618);
            this.Controls.Add(this.pnDangXuat);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnMain);
            this.MinimumSize = new System.Drawing.Size(909, 657);
            this.Name = "MenuGiangVien";
            this.Text = "MenuGiangVien";
            this.Resize += new System.EventHandler(this.MenuGiangVien_Resize);
            this.pnDangXuat.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHunre)).EndInit();
            this.pnKetQuaHocPhan.ResumeLayout(false);
            this.pnLopHoc.ResumeLayout(false);
            this.pnTaiKhoan.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDangXuat;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.PictureBox iconMenu;
        private System.Windows.Forms.PictureBox logoHunre;
        private System.Windows.Forms.Button btTaiKhoan;
        private System.Windows.Forms.Button btLopHoc;
        private System.Windows.Forms.Panel pnKetQuaHocPhan;
        private System.Windows.Forms.Button btKetQuaHocPhan;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Panel pnLopHoc;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnTaiKhoan;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
    }
}