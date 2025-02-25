namespace QLSinhVienHunre
{
    partial class ThamGiaHocPhanForm
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
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.tbMaSinhVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddAll = new System.Windows.Forms.Button();
            this.cbMaLopHocPhan = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGVSinhVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVThamGia = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSinhVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.groupBox1.Controls.Add(this.cbMaLop);
            this.groupBox1.Controls.Add(this.tbMaSinhVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btAddAll);
            this.groupBox1.Controls.Add(this.cbMaLopHocPhan);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(258, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 205);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbMaLop
            // 
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(121, 51);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(100, 21);
            this.cbMaLop.TabIndex = 16;
            this.cbMaLop.SelectedValueChanged += new System.EventHandler(this.cbMaLop_SelectedValueChanged);
            // 
            // tbMaSinhVien
            // 
            this.tbMaSinhVien.Location = new System.Drawing.Point(121, 78);
            this.tbMaSinhVien.Name = "tbMaSinhVien";
            this.tbMaSinhVien.ReadOnly = true;
            this.tbMaSinhVien.Size = new System.Drawing.Size(100, 20);
            this.tbMaSinhVien.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã sinh viên";
            // 
            // btAddAll
            // 
            this.btAddAll.Location = new System.Drawing.Point(8, 133);
            this.btAddAll.Name = "btAddAll";
            this.btAddAll.Size = new System.Drawing.Size(213, 23);
            this.btAddAll.TabIndex = 13;
            this.btAddAll.Text = "Thêm lớp";
            this.btAddAll.UseVisualStyleBackColor = true;
            this.btAddAll.Click += new System.EventHandler(this.btAddAll_Click);
            // 
            // cbMaLopHocPhan
            // 
            this.cbMaLopHocPhan.FormattingEnabled = true;
            this.cbMaLopHocPhan.Location = new System.Drawing.Point(121, 26);
            this.cbMaLopHocPhan.Name = "cbMaLopHocPhan";
            this.cbMaLopHocPhan.Size = new System.Drawing.Size(100, 21);
            this.cbMaLopHocPhan.TabIndex = 12;
            this.cbMaLopHocPhan.SelectedValueChanged += new System.EventHandler(this.cbMaLopHocPhan_SelectedValueChanged);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(8, 162);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(213, 23);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(8, 104);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(213, 23);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã lớp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dGVSinhVien);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 472);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sinh viên chưa đăng ký";
            // 
            // dGVSinhVien
            // 
            this.dGVSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSinhVien.Location = new System.Drawing.Point(6, 19);
            this.dGVSinhVien.Name = "dGVSinhVien";
            this.dGVSinhVien.Size = new System.Drawing.Size(228, 447);
            this.dGVSinhVien.TabIndex = 0;
            this.dGVSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSinhVien_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGVThamGia);
            this.groupBox2.Location = new System.Drawing.Point(491, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 472);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên đã đăng ký";
            // 
            // dGVThamGia
            // 
            this.dGVThamGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVThamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVThamGia.Location = new System.Drawing.Point(6, 19);
            this.dGVThamGia.Name = "dGVThamGia";
            this.dGVThamGia.Size = new System.Drawing.Size(228, 447);
            this.dGVThamGia.TabIndex = 1;
            this.dGVThamGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVThamGia_CellClick);
            // 
            // ThamGiaHocPhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "ThamGiaHocPhanForm";
            this.Text = "ThamGiaHocPhanForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSinhVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVThamGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox cbMaLopHocPhan;
        private System.Windows.Forms.DataGridView dGVSinhVien;
        private System.Windows.Forms.DataGridView dGVThamGia;
        private System.Windows.Forms.TextBox tbMaSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddAll;
        private System.Windows.Forms.ComboBox cbMaLop;
    }
}