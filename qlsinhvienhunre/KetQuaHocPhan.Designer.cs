namespace QLSinhVienHunre
{
    partial class KetQuaHocPhanForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btedit = new System.Windows.Forms.Button();
            this.tbDiemChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDiemSo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMSV = new System.Windows.Forms.TextBox();
            this.tbMLHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.dGVSinhVien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp học phần";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btedit);
            this.groupBox1.Controls.Add(this.tbDiemChu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDiemSo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMSV);
            this.groupBox1.Controls.Add(this.tbMLHP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(6, 130);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(215, 23);
            this.btedit.TabIndex = 10;
            this.btedit.Text = "Cập nhật";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // tbDiemChu
            // 
            this.tbDiemChu.Location = new System.Drawing.Point(121, 104);
            this.tbDiemChu.Name = "tbDiemChu";
            this.tbDiemChu.Size = new System.Drawing.Size(100, 20);
            this.tbDiemChu.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điểm chữ";
            // 
            // tbDiemSo
            // 
            this.tbDiemSo.Location = new System.Drawing.Point(121, 78);
            this.tbDiemSo.Name = "tbDiemSo";
            this.tbDiemSo.Size = new System.Drawing.Size(100, 20);
            this.tbDiemSo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm số";
            // 
            // tbMSV
            // 
            this.tbMSV.Location = new System.Drawing.Point(121, 52);
            this.tbMSV.Name = "tbMSV";
            this.tbMSV.ReadOnly = true;
            this.tbMSV.Size = new System.Drawing.Size(100, 20);
            this.tbMSV.TabIndex = 4;
            // 
            // tbMLHP
            // 
            this.tbMLHP.Location = new System.Drawing.Point(121, 26);
            this.tbMLHP.Name = "tbMLHP";
            this.tbMLHP.ReadOnly = true;
            this.tbMLHP.Size = new System.Drawing.Size(100, 20);
            this.tbMLHP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbHocKy);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbNamHoc);
            this.groupBox2.Controls.Add(this.dGVSinhVien);
            this.groupBox2.Location = new System.Drawing.Point(245, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 531);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Học kỳ";
            // 
            // cbHocKy
            // 
            this.cbHocKy.BackColor = System.Drawing.SystemColors.Window;
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "SV",
            "GV"});
            this.cbHocKy.Location = new System.Drawing.Point(253, 19);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(121, 21);
            this.cbHocKy.TabIndex = 9;
            this.cbHocKy.SelectedValueChanged += new System.EventHandler(this.cbHocKy_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Năm học";
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.BackColor = System.Drawing.SystemColors.Window;
            this.cbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Items.AddRange(new object[] {
            "SV",
            "GV"});
            this.cbNamHoc.Location = new System.Drawing.Point(63, 19);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(121, 21);
            this.cbNamHoc.TabIndex = 7;
            this.cbNamHoc.SelectedValueChanged += new System.EventHandler(this.cbNamHoc_SelectedValueChanged);
            // 
            // dGVSinhVien
            // 
            this.dGVSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSinhVien.Location = new System.Drawing.Point(5, 52);
            this.dGVSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.dGVSinhVien.Name = "dGVSinhVien";
            this.dGVSinhVien.RowHeadersWidth = 51;
            this.dGVSinhVien.RowTemplate.Height = 24;
            this.dGVSinhVien.Size = new System.Drawing.Size(546, 474);
            this.dGVSinhVien.TabIndex = 0;
            this.dGVSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSinhVien_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 10;
            // 
            // KetQuaHocPhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KetQuaHocPhanForm";
            this.Text = "Tham gia học phần";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDiemChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDiemSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMSV;
        private System.Windows.Forms.TextBox tbMLHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.DataGridView dGVSinhVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHocKy;
    }
}