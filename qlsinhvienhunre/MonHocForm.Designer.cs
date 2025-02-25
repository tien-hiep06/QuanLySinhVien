namespace QLSinhVienHunre
{
    partial class MonHocForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVMonHoc = new System.Windows.Forms.DataGridView();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.dTPNamBD = new System.Windows.Forms.DateTimePicker();
            this.panelQuyDnh = new System.Windows.Forms.Panel();
            this.batbuoc = new System.Windows.Forms.RadioButton();
            this.tuchon = new System.Windows.Forms.RadioButton();
            this.tbMoTaMH = new System.Windows.Forms.TextBox();
            this.cbHTDG = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSoTC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTenMH = new System.Windows.Forms.TextBox();
            this.tbMaMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSV = new System.Windows.Forms.Label();
            this.gbChucNang.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMonHoc)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.panelQuyDnh.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btnReset);
            this.gbChucNang.Controls.Add(this.btnDelete);
            this.gbChucNang.Controls.Add(this.btnEdit);
            this.gbChucNang.Controls.Add(this.btnAdd);
            this.gbChucNang.Location = new System.Drawing.Point(12, 444);
            this.gbChucNang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbChucNang.Size = new System.Drawing.Size(530, 315);
            this.gbChucNang.TabIndex = 7;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức Năng";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(270, 181);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(236, 123);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 181);
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
            this.btnEdit.Location = new System.Drawing.Point(270, 37);
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
            this.gbDanhSach.Controls.Add(this.dGVMonHoc);
            this.gbDanhSach.Location = new System.Drawing.Point(554, 23);
            this.gbDanhSach.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDanhSach.Size = new System.Drawing.Size(1498, 1246);
            this.gbDanhSach.TabIndex = 5;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh Sách Môn Học";
            // 
            // dGVMonHoc
            // 
            this.dGVMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMonHoc.Location = new System.Drawing.Point(12, 36);
            this.dGVMonHoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dGVMonHoc.Name = "dGVMonHoc";
            this.dGVMonHoc.RowHeadersWidth = 82;
            this.dGVMonHoc.Size = new System.Drawing.Size(1474, 1198);
            this.dGVMonHoc.TabIndex = 0;
            this.dGVMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSinhVien_CellClick);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.dTPNamBD);
            this.gbThongTin.Controls.Add(this.panelQuyDnh);
            this.gbThongTin.Controls.Add(this.tbMoTaMH);
            this.gbThongTin.Controls.Add(this.cbHTDG);
            this.gbThongTin.Controls.Add(this.label7);
            this.gbThongTin.Controls.Add(this.tbSoTC);
            this.gbThongTin.Controls.Add(this.label6);
            this.gbThongTin.Controls.Add(this.tbTenMH);
            this.gbThongTin.Controls.Add(this.tbMaMH);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.lbSV);
            this.gbThongTin.Location = new System.Drawing.Point(12, 23);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbThongTin.Size = new System.Drawing.Size(530, 410);
            this.gbThongTin.TabIndex = 4;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin chi tiết";
            // 
            // dTPNamBD
            // 
            this.dTPNamBD.CustomFormat = "yyyy";
            this.dTPNamBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNamBD.Location = new System.Drawing.Point(192, 194);
            this.dTPNamBD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dTPNamBD.Name = "dTPNamBD";
            this.dTPNamBD.Size = new System.Drawing.Size(298, 31);
            this.dTPNamBD.TabIndex = 20;
            // 
            // panelQuyDnh
            // 
            this.panelQuyDnh.Controls.Add(this.batbuoc);
            this.panelQuyDnh.Controls.Add(this.tuchon);
            this.panelQuyDnh.Location = new System.Drawing.Point(192, 244);
            this.panelQuyDnh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelQuyDnh.Name = "panelQuyDnh";
            this.panelQuyDnh.Size = new System.Drawing.Size(302, 44);
            this.panelQuyDnh.TabIndex = 19;
            // 
            // batbuoc
            // 
            this.batbuoc.AutoSize = true;
            this.batbuoc.Location = new System.Drawing.Point(10, 6);
            this.batbuoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.batbuoc.Name = "batbuoc";
            this.batbuoc.Size = new System.Drawing.Size(128, 29);
            this.batbuoc.TabIndex = 17;
            this.batbuoc.TabStop = true;
            this.batbuoc.Text = "Bắt buộc";
            this.batbuoc.UseVisualStyleBackColor = true;
            // 
            // tuchon
            // 
            this.tuchon.AutoSize = true;
            this.tuchon.Location = new System.Drawing.Point(158, 6);
            this.tuchon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tuchon.Name = "tuchon";
            this.tuchon.Size = new System.Drawing.Size(121, 29);
            this.tuchon.TabIndex = 18;
            this.tuchon.TabStop = true;
            this.tuchon.Text = "Tự chọn";
            this.tuchon.UseVisualStyleBackColor = true;
            // 
            // tbMoTaMH
            // 
            this.tbMoTaMH.Location = new System.Drawing.Point(190, 302);
            this.tbMoTaMH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbMoTaMH.Name = "tbMoTaMH";
            this.tbMoTaMH.Size = new System.Drawing.Size(300, 31);
            this.tbMoTaMH.TabIndex = 16;
            // 
            // cbHTDG
            // 
            this.cbHTDG.FormattingEnabled = true;
            this.cbHTDG.Location = new System.Drawing.Point(260, 352);
            this.cbHTDG.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbHTDG.Name = "cbHTDG";
            this.cbHTDG.Size = new System.Drawing.Size(230, 33);
            this.cbHTDG.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hình Thức Đánh Giá";
            // 
            // tbSoTC
            // 
            this.tbSoTC.Location = new System.Drawing.Point(190, 144);
            this.tbSoTC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbSoTC.Name = "tbSoTC";
            this.tbSoTC.Size = new System.Drawing.Size(300, 31);
            this.tbSoTC.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mô Tả Môn Học";
            // 
            // tbTenMH
            // 
            this.tbTenMH.Location = new System.Drawing.Point(190, 94);
            this.tbTenMH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbTenMH.Name = "tbTenMH";
            this.tbTenMH.Size = new System.Drawing.Size(300, 31);
            this.tbTenMH.TabIndex = 6;
            // 
            // tbMaMH
            // 
            this.tbMaMH.Location = new System.Drawing.Point(190, 44);
            this.tbMaMH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbMaMH.Name = "tbMaMH";
            this.tbMaMH.ReadOnly = true;
            this.tbMaMH.Size = new System.Drawing.Size(300, 31);
            this.tbMaMH.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quy Định";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm Bắt Đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Tín Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Môn Học";
            // 
            // lbSV
            // 
            this.lbSV.AutoSize = true;
            this.lbSV.Location = new System.Drawing.Point(12, 50);
            this.lbSV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSV.Name = "lbSV";
            this.lbSV.Size = new System.Drawing.Size(134, 25);
            this.lbSV.TabIndex = 0;
            this.lbSV.Text = "Mã Môn Học";
            // 
            // MonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 1292);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbThongTin);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MonHocForm";
            this.Text = "MonHocForm";
            this.gbChucNang.ResumeLayout(false);
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMonHoc)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.panelQuyDnh.ResumeLayout(false);
            this.panelQuyDnh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dGVMonHoc;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTenMH;
        private System.Windows.Forms.TextBox tbMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSV;
        private System.Windows.Forms.TextBox tbSoTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbHTDG;
        private System.Windows.Forms.TextBox tbMoTaMH;
        private System.Windows.Forms.Panel panelQuyDnh;
        private System.Windows.Forms.RadioButton batbuoc;
        private System.Windows.Forms.RadioButton tuchon;
        private System.Windows.Forms.DateTimePicker dTPNamBD;
    }
}