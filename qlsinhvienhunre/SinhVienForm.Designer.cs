namespace QLSinhVienHunre
{
    partial class SinhVienForm
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
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.dTPNam = new System.Windows.Forms.DateTimePicker();
            this.panelGioiTinh = new System.Windows.Forms.Panel();
            this.nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.dTPNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVSinhVien = new System.Windows.Forms.DataGridView();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbThongTin.SuspendLayout();
            this.panelGioiTinh.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSinhVien)).BeginInit();
            this.gbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.dTPNam);
            this.gbThongTin.Controls.Add(this.panelGioiTinh);
            this.gbThongTin.Controls.Add(this.dTPNgaySinh);
            this.gbThongTin.Controls.Add(this.tbHoTen);
            this.gbThongTin.Controls.Add(this.tbMaSV);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.lbSV);
            this.gbThongTin.Location = new System.Drawing.Point(24, 23);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbThongTin.Size = new System.Drawing.Size(506, 312);
            this.gbThongTin.TabIndex = 0;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin chi tiết";
            // 
            // dTPNam
            // 
            this.dTPNam.CustomFormat = "yyyy";
            this.dTPNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNam.Location = new System.Drawing.Point(226, 256);
            this.dTPNam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dTPNam.Name = "dTPNam";
            this.dTPNam.Size = new System.Drawing.Size(112, 31);
            this.dTPNam.TabIndex = 9;
            // 
            // panelGioiTinh
            // 
            this.panelGioiTinh.Controls.Add(this.nu);
            this.panelGioiTinh.Controls.Add(this.nam);
            this.panelGioiTinh.Location = new System.Drawing.Point(226, 194);
            this.panelGioiTinh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelGioiTinh.Name = "panelGioiTinh";
            this.panelGioiTinh.Size = new System.Drawing.Size(200, 50);
            this.panelGioiTinh.TabIndex = 4;
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(112, 10);
            this.nu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(70, 29);
            this.nu.TabIndex = 1;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Location = new System.Drawing.Point(6, 10);
            this.nam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(87, 29);
            this.nam.TabIndex = 0;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // dTPNgaySinh
            // 
            this.dTPNgaySinh.CustomFormat = "";
            this.dTPNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPNgaySinh.Location = new System.Drawing.Point(226, 144);
            this.dTPNgaySinh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dTPNgaySinh.Name = "dTPNgaySinh";
            this.dTPNgaySinh.Size = new System.Drawing.Size(258, 31);
            this.dTPNgaySinh.TabIndex = 8;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(226, 94);
            this.tbHoTen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(258, 31);
            this.tbHoTen.TabIndex = 6;
            // 
            // tbMaSV
            // 
            this.tbMaSV.Location = new System.Drawing.Point(226, 44);
            this.tbMaSV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.ReadOnly = true;
            this.tbMaSV.Size = new System.Drawing.Size(258, 31);
            this.tbMaSV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Năm nhập học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // lbSV
            // 
            this.lbSV.AutoSize = true;
            this.lbSV.Location = new System.Drawing.Point(12, 50);
            this.lbSV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSV.Name = "lbSV";
            this.lbSV.Size = new System.Drawing.Size(134, 25);
            this.lbSV.TabIndex = 0;
            this.lbSV.Text = "Mã sinh viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lớp";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "fdfd",
            "fdfhdj",
            "hjhdf"});
            this.cbLop.Location = new System.Drawing.Point(76, 44);
            this.cbLop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(190, 33);
            this.cbLop.TabIndex = 10;
            this.cbLop.SelectedValueChanged += new System.EventHandler(this.cbLop_SelectedValueChanged);
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDanhSach.Controls.Add(this.dGVSinhVien);
            this.gbDanhSach.Controls.Add(this.label6);
            this.gbDanhSach.Controls.Add(this.cbLop);
            this.gbDanhSach.Location = new System.Drawing.Point(542, 23);
            this.gbDanhSach.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDanhSach.Size = new System.Drawing.Size(1010, 823);
            this.gbDanhSach.TabIndex = 1;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh sách sinh viên";
            // 
            // dGVSinhVien
            // 
            this.dGVSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSinhVien.Location = new System.Drawing.Point(12, 94);
            this.dGVSinhVien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dGVSinhVien.Name = "dGVSinhVien";
            this.dGVSinhVien.RowHeadersWidth = 82;
            this.dGVSinhVien.Size = new System.Drawing.Size(986, 717);
            this.dGVSinhVien.TabIndex = 0;
            this.dGVSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSinhVien_CellClick);
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btnReset);
            this.gbChucNang.Controls.Add(this.btnDelete);
            this.gbChucNang.Controls.Add(this.btnEdit);
            this.gbChucNang.Controls.Add(this.btnAdd);
            this.gbChucNang.Location = new System.Drawing.Point(24, 346);
            this.gbChucNang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbChucNang.Size = new System.Drawing.Size(504, 337);
            this.gbChucNang.TabIndex = 3;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức Năng";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(256, 171);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(232, 135);
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
            this.btnDelete.Size = new System.Drawing.Size(232, 135);
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
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 885);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbThongTin);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SinhVienForm";
            this.Text = "Form1";
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.panelGioiTinh.ResumeLayout(false);
            this.panelGioiTinh.PerformLayout();
            this.gbDanhSach.ResumeLayout(false);
            this.gbDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSinhVien)).EndInit();
            this.gbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.Label lbSV;
        private System.Windows.Forms.GroupBox gbChucNang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.DateTimePicker dTPNgaySinh;
        private System.Windows.Forms.Panel panelGioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dGVSinhVien;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.DateTimePicker dTPNam;
    }
}