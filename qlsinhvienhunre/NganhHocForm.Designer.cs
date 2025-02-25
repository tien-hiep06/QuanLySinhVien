namespace QLSinhVienHunre
{
    partial class NganhHocForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTPNam = new System.Windows.Forms.DateTimePicker();
            this.tbSoTC = new System.Windows.Forms.TextBox();
            this.tbTenNH = new System.Windows.Forms.TextBox();
            this.tbMaNH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.dGVNganhHoc = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNganhHoc)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPNam);
            this.groupBox1.Controls.Add(this.tbSoTC);
            this.groupBox1.Controls.Add(this.tbTenNH);
            this.groupBox1.Controls.Add(this.tbMaNH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(578, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dTPNam
            // 
            this.dTPNam.CustomFormat = "yyyy";
            this.dTPNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNam.Location = new System.Drawing.Point(234, 213);
            this.dTPNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTPNam.Name = "dTPNam";
            this.dTPNam.Size = new System.Drawing.Size(134, 37);
            this.dTPNam.TabIndex = 7;
            // 
            // tbSoTC
            // 
            this.tbSoTC.Location = new System.Drawing.Point(234, 162);
            this.tbSoTC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbSoTC.Name = "tbSoTC";
            this.tbSoTC.ReadOnly = true;
            this.tbSoTC.Size = new System.Drawing.Size(316, 37);
            this.tbSoTC.TabIndex = 6;
            // 
            // tbTenNH
            // 
            this.tbTenNH.Location = new System.Drawing.Point(234, 108);
            this.tbTenNH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbTenNH.Name = "tbTenNH";
            this.tbTenNH.Size = new System.Drawing.Size(316, 37);
            this.tbTenNH.TabIndex = 5;
            // 
            // tbMaNH
            // 
            this.tbMaNH.Location = new System.Drawing.Point(234, 54);
            this.tbMaNH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbMaNH.Name = "tbMaNH";
            this.tbMaNH.ReadOnly = true;
            this.tbMaNH.Size = new System.Drawing.Size(316, 37);
            this.tbMaNH.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Năm bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số tín chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên ngành học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã ngành học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btReset);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 306);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(578, 262);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 185);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(524, 56);
            this.button5.TabIndex = 5;
            this.button5.Text = "Phân chia môn học";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btReset
            // 
            this.btReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReset.Location = new System.Drawing.Point(312, 113);
            this.btReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(242, 60);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btThem
            // 
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btThem.Location = new System.Drawing.Point(30, 40);
            this.btThem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(242, 60);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btXoa.Location = new System.Drawing.Point(30, 112);
            this.btXoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(242, 60);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btSua.Location = new System.Drawing.Point(312, 38);
            this.btSua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(242, 62);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // dGVNganhHoc
            // 
            this.dGVNganhHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVNganhHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNganhHoc.Location = new System.Drawing.Point(12, 42);
            this.dGVNganhHoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dGVNganhHoc.Name = "dGVNganhHoc";
            this.dGVNganhHoc.RowHeadersWidth = 51;
            this.dGVNganhHoc.Size = new System.Drawing.Size(1204, 668);
            this.dGVNganhHoc.TabIndex = 3;
            this.dGVNganhHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVNganhHoc_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dGVNganhHoc);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(614, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(1228, 721);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // NganhHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 767);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "NganhHocForm";
            this.Text = "NganhHoc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVNganhHoc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenNH;
        private System.Windows.Forms.TextBox tbMaNH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.DataGridView dGVNganhHoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dTPNam;
        private System.Windows.Forms.TextBox tbSoTC;
        private System.Windows.Forms.Button button5;
    }
}