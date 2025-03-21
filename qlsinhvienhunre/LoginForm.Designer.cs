﻿namespace QLSinhVienHunre
{
    partial class LoginForm
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
            this.btHelp = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btForgot = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dangnhap_button = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::QLSinhVienHunre.Properties.Resources.loginform;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btHelp);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.btForgot);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.tbPassWord);
            this.panel1.Location = new System.Drawing.Point(167, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 371);
            this.panel1.TabIndex = 0;
            // 
            // btHelp
            // 
            this.btHelp.FlatAppearance.BorderSize = 0;
            this.btHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btHelp.Image = global::QLSinhVienHunre.Properties.Resources.question;
            this.btHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHelp.Location = new System.Drawing.Point(142, 288);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(78, 23);
            this.btHelp.TabIndex = 38;
            this.btHelp.Text = "Trợ giúp";
            this.btHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHelp.UseVisualStyleBackColor = true;
            this.btHelp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btChangeStyle_MouseDown);
            this.btHelp.MouseEnter += new System.EventHandler(this.btChangeStyle_MouseEnter);
            this.btHelp.MouseLeave += new System.EventHandler(this.btChangeStyle_MouseLeave);
            // 
            // btExit
            // 
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btExit.Image = global::QLSinhVienHunre.Properties.Resources.exit;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.Location = new System.Drawing.Point(255, 199);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(62, 23);
            this.btExit.TabIndex = 37;
            this.btExit.Text = "Thoát";
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            this.btExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btChangeStyle_MouseDown);
            this.btExit.MouseEnter += new System.EventHandler(this.btChangeStyle_MouseEnter);
            this.btExit.MouseLeave += new System.EventHandler(this.btChangeStyle_MouseLeave);
            // 
            // btForgot
            // 
            this.btForgot.FlatAppearance.BorderSize = 0;
            this.btForgot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btForgot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.btForgot.Image = global::QLSinhVienHunre.Properties.Resources.forgot;
            this.btForgot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btForgot.Location = new System.Drawing.Point(43, 199);
            this.btForgot.Name = "btForgot";
            this.btForgot.Size = new System.Drawing.Size(116, 23);
            this.btForgot.TabIndex = 2;
            this.btForgot.Text = "Quên mật khẩu";
            this.btForgot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btForgot.UseVisualStyleBackColor = true;
            this.btForgot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btChangeStyle_MouseDown);
            this.btForgot.MouseEnter += new System.EventHandler(this.btChangeStyle_MouseEnter);
            this.btForgot.MouseLeave += new System.EventHandler(this.btChangeStyle_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dangnhap_button);
            this.panel2.Location = new System.Drawing.Point(43, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 31);
            this.panel2.TabIndex = 36;
            // 
            // dangnhap_button
            // 
            this.dangnhap_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.dangnhap_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.dangnhap_button.FlatAppearance.BorderSize = 0;
            this.dangnhap_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.dangnhap_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.dangnhap_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhap_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap_button.ForeColor = System.Drawing.Color.White;
            this.dangnhap_button.Location = new System.Drawing.Point(-10, -8);
            this.dangnhap_button.Margin = new System.Windows.Forms.Padding(2);
            this.dangnhap_button.Name = "dangnhap_button";
            this.dangnhap_button.Size = new System.Drawing.Size(297, 47);
            this.dangnhap_button.TabIndex = 33;
            this.dangnhap_button.Text = "ĐĂNG NHẬP";
            this.dangnhap_button.UseVisualStyleBackColor = false;
            this.dangnhap_button.Click += new System.EventHandler(this.dangnhap_button_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLSinhVienHunre.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(55, 168);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLSinhVienHunre.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(55, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(103, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.button1.BackgroundImage = global::QLSinhVienHunre.Properties.Resources.show;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(285, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 19);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(83, 128);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(222, 18);
            this.tbUserName.TabIndex = 30;
            this.tbUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tbPassWord
            // 
            this.tbPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.tbPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassWord.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassWord.Location = new System.Drawing.Point(83, 169);
            this.tbPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(193, 18);
            this.tbPassWord.TabIndex = 31;
            this.tbPassWord.UseSystemPasswordChar = true;
            this.tbPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.pictureBox1.Image = global::QLSinhVienHunre.Properties.Resources.logologin;
            this.pictureBox1.Location = new System.Drawing.Point(159, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.BackgroundImage = global::QLSinhVienHunre.Properties.Resources.bg_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(689, 633);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(689, 633);
            this.MinimumSize = new System.Drawing.Size(689, 633);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Button dangnhap_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btForgot;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btHelp;
    }
}