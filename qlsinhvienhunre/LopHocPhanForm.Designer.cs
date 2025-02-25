namespace quanlisinhvienHUNRE
{
    partial class LopHocPhanForm
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
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btThamGiaHocPhan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVLopHP = new System.Windows.Forms.DataGridView();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.dTPNamHoc = new System.Windows.Forms.DateTimePicker();
            this.panelHocKi = new System.Windows.Forms.Panel();
            this.rdKi2 = new System.Windows.Forms.RadioButton();
            this.rdKi1 = new System.Windows.Forms.RadioButton();
            this.cbTenMH = new System.Windows.Forms.ComboBox();
            this.cbTenGV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMoTa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGioiHSV = new System.Windows.Forms.TextBox();
            this.tbMaHP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSV = new System.Windows.Forms.Label();
            this.gbChucNang.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLopHP)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.panelHocKi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btThamGiaHocPhan);
            this.gbChucNang.Controls.Add(this.btnReset);
            this.gbChucNang.Controls.Add(this.btnDelete);
            this.gbChucNang.Controls.Add(this.btnEdit);
            this.gbChucNang.Controls.Add(this.btnAdd);
            this.gbChucNang.Location = new System.Drawing.Point(20, 431);
            this.gbChucNang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbChucNang.Size = new System.Drawing.Size(504, 410);
            this.gbChucNang.TabIndex = 11;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức Năng";
            // 
            // btThamGiaHocPhan
            // 
            this.btThamGiaHocPhan.Location = new System.Drawing.Point(12, 306);
            this.btThamGiaHocPhan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btThamGiaHocPhan.Name = "btThamGiaHocPhan";
            this.btThamGiaHocPhan.Size = new System.Drawing.Size(476, 92);
            this.btThamGiaHocPhan.TabIndex = 4;
            this.btThamGiaHocPhan.Text = "Tham gia học phần";
            this.btThamGiaHocPhan.UseVisualStyleBackColor = true;
            this.btThamGiaHocPhan.Click += new System.EventHandler(this.btThamGiaHocPhan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(256, 171);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(232, 123);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 171);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 123);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Location = new System.Drawing.Point(256, 37);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(236, 123);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 37);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(232, 123);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm mới ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDanhSach.Controls.Add(this.dGVLopHP);
            this.gbDanhSach.Location = new System.Drawing.Point(542, 21);
            this.gbDanhSach.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDanhSach.Size = new System.Drawing.Size(1356, 1015);
            this.gbDanhSach.TabIndex = 9;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh Sách Lớp Học Phần";
            // 
            // dGVLopHP
            // 
            this.dGVLopHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVLopHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLopHP.Location = new System.Drawing.Point(14, 36);
            this.dGVLopHP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dGVLopHP.Name = "dGVLopHP";
            this.dGVLopHP.RowHeadersWidth = 82;
            this.dGVLopHP.Size = new System.Drawing.Size(1332, 968);
            this.dGVLopHP.TabIndex = 0;
            this.dGVLopHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVLopHP_CellClick);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.dTPNamHoc);
            this.gbThongTin.Controls.Add(this.panelHocKi);
            this.gbThongTin.Controls.Add(this.cbTenMH);
            this.gbThongTin.Controls.Add(this.cbTenGV);
            this.gbThongTin.Controls.Add(this.label7);
            this.gbThongTin.Controls.Add(this.tbMoTa);
            this.gbThongTin.Controls.Add(this.label6);
            this.gbThongTin.Controls.Add(this.tbGioiHSV);
            this.gbThongTin.Controls.Add(this.tbMaHP);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.lbSV);
            this.gbThongTin.Location = new System.Drawing.Point(20, 21);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbThongTin.Size = new System.Drawing.Size(506, 398);
            this.gbThongTin.TabIndex = 8;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin chi tiết";
            // 
            // dTPNamHoc
            // 
            this.dTPNamHoc.CustomFormat = "yyyy";
            this.dTPNamHoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNamHoc.Location = new System.Drawing.Point(218, 96);
            this.dTPNamHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTPNamHoc.Name = "dTPNamHoc";
            this.dTPNamHoc.Size = new System.Drawing.Size(134, 31);
            this.dTPNamHoc.TabIndex = 8;
            // 
            // panelHocKi
            // 
            this.panelHocKi.Controls.Add(this.rdKi2);
            this.panelHocKi.Controls.Add(this.rdKi1);
            this.panelHocKi.Location = new System.Drawing.Point(218, 144);
            this.panelHocKi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelHocKi.Name = "panelHocKi";
            this.panelHocKi.Size = new System.Drawing.Size(250, 38);
            this.panelHocKi.TabIndex = 17;
            // 
            // rdKi2
            // 
            this.rdKi2.AutoSize = true;
            this.rdKi2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKi2.Location = new System.Drawing.Point(96, 0);
            this.rdKi2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdKi2.Name = "rdKi2";
            this.rdKi2.Size = new System.Drawing.Size(55, 29);
            this.rdKi2.TabIndex = 1;
            this.rdKi2.TabStop = true;
            this.rdKi2.Text = "II";
            this.rdKi2.UseVisualStyleBackColor = true;
            // 
            // rdKi1
            // 
            this.rdKi1.AutoSize = true;
            this.rdKi1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKi1.Location = new System.Drawing.Point(6, 0);
            this.rdKi1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdKi1.Name = "rdKi1";
            this.rdKi1.Size = new System.Drawing.Size(49, 29);
            this.rdKi1.TabIndex = 0;
            this.rdKi1.TabStop = true;
            this.rdKi1.Text = "I";
            this.rdKi1.UseVisualStyleBackColor = true;
            // 
            // cbTenMH
            // 
            this.cbTenMH.FormattingEnabled = true;
            this.cbTenMH.Items.AddRange(new object[] {
            "fdfd",
            "fdfhdj",
            "hjhdf"});
            this.cbTenMH.Location = new System.Drawing.Point(220, 294);
            this.cbTenMH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbTenMH.Name = "cbTenMH";
            this.cbTenMH.Size = new System.Drawing.Size(244, 33);
            this.cbTenMH.TabIndex = 16;
            // 
            // cbTenGV
            // 
            this.cbTenGV.FormattingEnabled = true;
            this.cbTenGV.Items.AddRange(new object[] {
            "fdfd",
            "fdfhdj",
            "hjhdf"});
            this.cbTenGV.Location = new System.Drawing.Point(220, 346);
            this.cbTenGV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbTenGV.Name = "cbTenGV";
            this.cbTenGV.Size = new System.Drawing.Size(244, 33);
            this.cbTenGV.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên giáo viên";
            // 
            // tbMoTa
            // 
            this.tbMoTa.Location = new System.Drawing.Point(218, 194);
            this.tbMoTa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbMoTa.Name = "tbMoTa";
            this.tbMoTa.Size = new System.Drawing.Size(246, 31);
            this.tbMoTa.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên môn học";
            // 
            // tbGioiHSV
            // 
            this.tbGioiHSV.Location = new System.Drawing.Point(218, 244);
            this.tbGioiHSV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbGioiHSV.Name = "tbGioiHSV";
            this.tbGioiHSV.Size = new System.Drawing.Size(244, 31);
            this.tbGioiHSV.TabIndex = 9;
            // 
            // tbMaHP
            // 
            this.tbMaHP.Location = new System.Drawing.Point(218, 44);
            this.tbMaHP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbMaHP.Name = "tbMaHP";
            this.tbMaHP.ReadOnly = true;
            this.tbMaHP.Size = new System.Drawing.Size(246, 31);
            this.tbMaHP.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới hạn sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm Học";
            // 
            // lbSV
            // 
            this.lbSV.AutoSize = true;
            this.lbSV.Location = new System.Drawing.Point(18, 50);
            this.lbSV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSV.Name = "lbSV";
            this.lbSV.Size = new System.Drawing.Size(184, 25);
            this.lbSV.TabIndex = 0;
            this.lbSV.Text = "Mã Lớp Học Phần";
            // 
            // LopHocPhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 1050);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbThongTin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LopHocPhanForm";
            this.Text = "LopHoc";
            this.gbChucNang.ResumeLayout(false);
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLopHP)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.panelHocKi.ResumeLayout(false);
            this.panelHocKi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dGVLopHP;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.ComboBox cbTenGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMoTa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGioiHSV;
        private System.Windows.Forms.TextBox tbMaHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSV;
        private System.Windows.Forms.ComboBox cbTenMH;
        private System.Windows.Forms.Button btThamGiaHocPhan;
        private System.Windows.Forms.Panel panelHocKi;
        private System.Windows.Forms.RadioButton rdKi2;
        private System.Windows.Forms.RadioButton rdKi1;
        private System.Windows.Forms.DateTimePicker dTPNamHoc;
    }
}