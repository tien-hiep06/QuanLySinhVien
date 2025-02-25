namespace QLSinhVienHunre
{
    partial class ChiaMonForm
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
            this.dGVNganhHoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.cbMaNganh = new System.Windows.Forms.ComboBox();
            this.dGVMonHoc = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btCapNhatTC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNganhHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMonHoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVNganhHoc
            // 
            this.dGVNganhHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVNganhHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNganhHoc.Location = new System.Drawing.Point(6, 19);
            this.dGVNganhHoc.Name = "dGVNganhHoc";
            this.dGVNganhHoc.RowHeadersWidth = 82;
            this.dGVNganhHoc.Size = new System.Drawing.Size(388, 375);
            this.dGVNganhHoc.TabIndex = 1;
            this.dGVNganhHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVNganhHoc_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCapNhatTC);
            this.groupBox1.Controls.Add(this.tbMaMon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.cbMaNganh);
            this.groupBox1.Location = new System.Drawing.Point(418, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // tbMaMon
            // 
            this.tbMaMon.Location = new System.Drawing.Point(87, 46);
            this.tbMaMon.Name = "tbMaMon";
            this.tbMaMon.ReadOnly = true;
            this.tbMaMon.Size = new System.Drawing.Size(106, 20);
            this.tbMaMon.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã ngành";
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(6, 102);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(188, 23);
            this.buttonXoa.TabIndex = 5;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(6, 73);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(188, 23);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // cbMaNganh
            // 
            this.cbMaNganh.FormattingEnabled = true;
            this.cbMaNganh.Location = new System.Drawing.Point(87, 19);
            this.cbMaNganh.Name = "cbMaNganh";
            this.cbMaNganh.Size = new System.Drawing.Size(107, 21);
            this.cbMaNganh.TabIndex = 1;
            this.cbMaNganh.SelectedValueChanged += new System.EventHandler(this.cbMaNganh_SelectedValueChanged);
            // 
            // dGVMonHoc
            // 
            this.dGVMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMonHoc.Location = new System.Drawing.Point(6, 19);
            this.dGVMonHoc.Name = "dGVMonHoc";
            this.dGVMonHoc.RowHeadersWidth = 82;
            this.dGVMonHoc.Size = new System.Drawing.Size(388, 375);
            this.dGVMonHoc.TabIndex = 0;
            this.dGVMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVMonHoc_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.dGVNganhHoc);
            this.groupBox2.Location = new System.Drawing.Point(624, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 400);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn ngành";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dGVMonHoc);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 400);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách môn học";
            // 
            // btCapNhatTC
            // 
            this.btCapNhatTC.Location = new System.Drawing.Point(6, 131);
            this.btCapNhatTC.Name = "btCapNhatTC";
            this.btCapNhatTC.Size = new System.Drawing.Size(188, 23);
            this.btCapNhatTC.TabIndex = 9;
            this.btCapNhatTC.Text = "Cập nhật số tín chỉ";
            this.btCapNhatTC.UseVisualStyleBackColor = true;
            this.btCapNhatTC.Click += new System.EventHandler(this.btCapNhatTC_Click);
            // 
            // ChiaMonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChiaMonForm";
            this.Text = "Phân chia môn";
            ((System.ComponentModel.ISupportInitialize)(this.dGVNganhHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMonHoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVNganhHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbMaNganh;
        private System.Windows.Forms.DataGridView dGVMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbMaMon;
        private System.Windows.Forms.Button btCapNhatTC;
    }
}