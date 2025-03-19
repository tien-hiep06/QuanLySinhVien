namespace QLSinhVienHunre
{
    partial class MenuSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSinhVien));
            this.pnDangXuat = new System.Windows.Forms.Panel();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.btKetQua = new System.Windows.Forms.Button();
            this.btTTCN = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.iconMenu = new System.Windows.Forms.PictureBox();
            this.logoHunre = new System.Windows.Forms.PictureBox();
            this.pnTTCN = new System.Windows.Forms.Panel();
            this.pnkqht = new System.Windows.Forms.Panel();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.pnDangXuat.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHunre)).BeginInit();
            this.pnTTCN.SuspendLayout();
            this.pnkqht.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDangXuat
            // 
            this.pnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDangXuat.Controls.Add(this.btDangXuat);
            this.pnDangXuat.Location = new System.Drawing.Point(598, 7);
            this.pnDangXuat.Name = "pnDangXuat";
            this.pnDangXuat.Size = new System.Drawing.Size(189, 39);
            this.pnDangXuat.TabIndex = 4;
            // 
            // btDangXuat
            // 
            this.btDangXuat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDangXuat.ForeColor = System.Drawing.Color.Transparent;
            this.btDangXuat.Location = new System.Drawing.Point(-8, -2);
            this.btDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(206, 44);
            this.btDangXuat.TabIndex = 2;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.UseVisualStyleBackColor = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // btKetQua
            // 
            this.btKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btKetQua.FlatAppearance.BorderSize = 0;
            this.btKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKetQua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKetQua.ForeColor = System.Drawing.Color.Transparent;
            this.btKetQua.Image = ((System.Drawing.Image)(resources.GetObject("btKetQua.Image")));
            this.btKetQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKetQua.Location = new System.Drawing.Point(0, 0);
            this.btKetQua.Margin = new System.Windows.Forms.Padding(2);
            this.btKetQua.Name = "btKetQua";
            this.btKetQua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btKetQua.Size = new System.Drawing.Size(189, 40);
            this.btKetQua.TabIndex = 1;
            this.btKetQua.Text = "     Kết quả học tập";
            this.btKetQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btKetQua.UseVisualStyleBackColor = false;
            this.btKetQua.Click += new System.EventHandler(this.btKetQua_Click);
            // 
            // btTTCN
            // 
            this.btTTCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btTTCN.FlatAppearance.BorderSize = 0;
            this.btTTCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTTCN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTTCN.ForeColor = System.Drawing.Color.Transparent;
            this.btTTCN.Image = global::QLSinhVienHunre.Properties.Resources.account;
            this.btTTCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTTCN.Location = new System.Drawing.Point(0, 0);
            this.btTTCN.Margin = new System.Windows.Forms.Padding(2);
            this.btTTCN.Name = "btTTCN";
            this.btTTCN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btTTCN.Size = new System.Drawing.Size(189, 40);
            this.btTTCN.TabIndex = 0;
            this.btTTCN.Text = "    Thông tin cá nhân";
            this.btTTCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTTCN.UseVisualStyleBackColor = false;
            this.btTTCN.Click += new System.EventHandler(this.btTTCN_Click);
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.pnMain.Location = new System.Drawing.Point(68, 51);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(719, 425);
            this.pnMain.TabIndex = 4;
            this.pnMain.Resize += new System.EventHandler(this.pnMain_Resize);
            // 
            // sidebar
            // 
            this.sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.sidebar.Controls.Add(this.pnMenu);
            this.sidebar.Controls.Add(this.pnTTCN);
            this.sidebar.Controls.Add(this.pnkqht);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(191, 1000);
            this.sidebar.MinimumSize = new System.Drawing.Size(63, 1000);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(63, 1000);
            this.sidebar.TabIndex = 34;
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
            // pnTTCN
            // 
            this.pnTTCN.Controls.Add(this.btTTCN);
            this.pnTTCN.Location = new System.Drawing.Point(3, 105);
            this.pnTTCN.Name = "pnTTCN";
            this.pnTTCN.Size = new System.Drawing.Size(189, 40);
            this.pnTTCN.TabIndex = 35;
            // 
            // pnkqht
            // 
            this.pnkqht.Controls.Add(this.btKetQua);
            this.pnkqht.Location = new System.Drawing.Point(3, 151);
            this.pnkqht.Name = "pnkqht";
            this.pnkqht.Size = new System.Drawing.Size(189, 40);
            this.pnkqht.TabIndex = 35;
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 1;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // MenuSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSinhVienHunre.Properties.Resources.wrapper_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 487);
            this.Controls.Add(this.pnDangXuat);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnMain);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(814, 526);
            this.Name = "MenuSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuSinhVien";
            this.pnDangXuat.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHunre)).EndInit();
            this.pnTTCN.ResumeLayout(false);
            this.pnkqht.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Button btKetQua;
        private System.Windows.Forms.Button btTTCN;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.PictureBox iconMenu;
        private System.Windows.Forms.PictureBox logoHunre;
        private System.Windows.Forms.Panel pnTTCN;
        private System.Windows.Forms.Panel pnkqht;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Panel pnDangXuat;
    }
}