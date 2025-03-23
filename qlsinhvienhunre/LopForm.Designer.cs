namespace QLSinhVienHunre
{
    partial class LopForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaGiangVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaNganh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGVLop = new System.Windows.Forms.DataGridView();
            this.maNganhHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dGVGiangVien = new System.Windows.Forms.DataGridView();
            this.cbNamNhapHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLop)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNamNhapHoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbMaGiangVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMaLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thòng tin";
            // 
            // tbMaGiangVien
            // 
            this.tbMaGiangVien.Location = new System.Drawing.Point(87, 54);
            this.tbMaGiangVien.Name = "tbMaGiangVien";
            this.tbMaGiangVien.ReadOnly = true;
            this.tbMaGiangVien.Size = new System.Drawing.Size(100, 20);
            this.tbMaGiangVien.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã giảng viên";
            // 
            // tbMaLop
            // 
            this.tbMaLop.Location = new System.Drawing.Point(87, 28);
            this.tbMaLop.Name = "tbMaLop";
            this.tbMaLop.ReadOnly = true;
            this.tbMaLop.Size = new System.Drawing.Size(100, 20);
            this.tbMaLop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // cbMaNganh
            // 
            this.cbMaNganh.FormattingEnabled = true;
            this.cbMaNganh.Location = new System.Drawing.Point(67, 17);
            this.cbMaNganh.Name = "cbMaNganh";
            this.cbMaNganh.Size = new System.Drawing.Size(117, 21);
            this.cbMaNganh.TabIndex = 3;
            this.cbMaNganh.SelectedValueChanged += new System.EventHandler(this.cbMaNganh_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã ngành";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btReset);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.btEdit);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(99, 48);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(88, 23);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(6, 48);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(88, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(99, 19);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(88, 23);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(6, 19);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(88, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbMaNganh);
            this.groupBox3.Controls.Add(this.dGVLop);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(211, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 530);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách lớp";
            // 
            // dGVLop
            // 
            this.dGVLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNganhHoc});
            this.dGVLop.Location = new System.Drawing.Point(7, 46);
            this.dGVLop.Name = "dGVLop";
            this.dGVLop.RowHeadersWidth = 51;
            this.dGVLop.Size = new System.Drawing.Size(577, 478);
            this.dGVLop.TabIndex = 0;
            this.dGVLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVLop_CellClick);
            // 
            // maNganhHoc
            // 
            this.maNganhHoc.DataPropertyName = "maNganhHoc";
            this.maNganhHoc.HeaderText = "Mã ngành học";
            this.maNganhHoc.MinimumWidth = 6;
            this.maNganhHoc.Name = "maNganhHoc";
            this.maNganhHoc.Visible = false;
            this.maNganhHoc.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 170);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.dGVGiangVien);
            this.groupBox4.Location = new System.Drawing.Point(12, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 332);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách giảng viên";
            // 
            // dGVGiangVien
            // 
            this.dGVGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGiangVien.Location = new System.Drawing.Point(7, 20);
            this.dGVGiangVien.Name = "dGVGiangVien";
            this.dGVGiangVien.RowHeadersWidth = 51;
            this.dGVGiangVien.Size = new System.Drawing.Size(180, 306);
            this.dGVGiangVien.TabIndex = 0;
            this.dGVGiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVGiangVien_CellClick);
            // 
            // cbNamNhapHoc
            // 
            this.cbNamNhapHoc.DropDownHeight = 80;
            this.cbNamNhapHoc.FormattingEnabled = true;
            this.cbNamNhapHoc.IntegralHeight = false;
            this.cbNamNhapHoc.Location = new System.Drawing.Point(88, 80);
            this.cbNamNhapHoc.Name = "cbNamNhapHoc";
            this.cbNamNhapHoc.Size = new System.Drawing.Size(99, 21);
            this.cbNamNhapHoc.TabIndex = 14;
            this.cbNamNhapHoc.SelectedValueChanged += new System.EventHandler(this.cbNamNhapHoc_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Năm nhập học";
            // 
            // LopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 555);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LopForm";
            this.Text = "LopForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLop)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiangVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaNganh;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dGVLop;
        private System.Windows.Forms.TextBox tbMaGiangVien;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dGVGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNganhHoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbNamNhapHoc;
        private System.Windows.Forms.Label label5;
    }
}