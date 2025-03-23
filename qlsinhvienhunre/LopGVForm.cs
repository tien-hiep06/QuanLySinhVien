using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienHunre
{
    public partial class LopGVForm: Form
    {
        public string maGV;
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();

        public LopGVForm(string maGV)
        {
            this.maGV = maGV;
            InitializeComponent();
            LoadData();
        }

        #region load data
        //Load Data controls
        void LoadData()
        {
            cbLop.DataSource = db.Lop.Select(p => p.maLop).ToList();
            cbNamNhaphoc.DataSource = db.SinhVien.Select(p => p.namNhapHoc).Distinct().OrderByDescending(n => n).ToList();
            LoadDGVLopSV();
            LoadDGVClassNull();
        }
        void LoadDGVLopSV()
        {
            int namNhapHoc = SelectComboboxValue(cbNamNhaphoc);

            var resultLopSV = from c in db.SinhVien
                              where c.Lop.GiangVien.maGiangVien == maGV
                              && c.Lop.maLop == cbLop.SelectedValue.ToString()
                              && c.namNhapHoc == namNhapHoc
                              select new
                              {
                                  maSinhVien = c.maSinhVien,
                                  hotenSinhVien = c.hotenSinhVien,
                                  ngaySinh = c.ngaySinh,
                                  gioiTinh = c.gioiTinh,
                                  namNhapHoc = c.namNhapHoc
                              };
            dgvLop.DataSource = resultLopSV.ToList();
        }

        void LoadDGVClassNull() {
            int namNhapHoc = SelectComboboxValue(cbNamNhaphoc);

            var resultClassNull = from c in db.SinhVien
                                  where c.Lop.maLop == null 
                                  && c.namNhapHoc == namNhapHoc
                                  select new
                                  {
                                      maSinhVien = c.maSinhVien,
                                      hotenSinhVien = c.hotenSinhVien,
                                      ngaySinh = c.ngaySinh,
                                      gioiTinh = c.gioiTinh,
                                      namNhapHoc = c.namNhapHoc
                                  };
            dgvSVKL.DataSource = resultClassNull.ToList();
        }
        #endregion

        #region methods

        // Gắn dữ liệu cho labelMSV
        void AddBinding(object dgv)
        {
            lbMSV.DataBindings.Add("Text", dgv, "maSinhVien", true, DataSourceUpdateMode.Never);
        }

        // Làm sạch dữ liệu
        void ClearBinding()
        {
            lbMSV.DataBindings.Clear();
        }

        int SelectComboboxValue(ComboBox cb)
        {
            int value;
            if (!int.TryParse(cb.SelectedValue?.ToString(), out value))
            {
                value = 0;
            }
            return value;
        }

        SinhVien SelectSinhVien (String maSinhVien)
        {
            SinhVien sinhVien = db.SinhVien.Where(p => p.maSinhVien == maSinhVien).SingleOrDefault();
            return sinhVien;
        }


        Lop SelectLop(String maLop)
        {
            Lop lop = db.Lop.Where(p => p.maLop == maLop).SingleOrDefault();
            return lop;
        }

        void AddData(String maSinhVien, String maLop)
        {
            int idsv = SelectSinhVien(maSinhVien).idSinhVien;
            int idlop = SelectLop(maLop).idLop;
            if (SelectSinhVien(maSinhVien).idLop == null)
            {
                SinhVien sinhVien = db.SinhVien.Find(idsv);
                sinhVien.idLop = idlop;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Sinh viên " + maSinhVien + " đã có lớp" + SelectSinhVien(maSinhVien).Lop.maLop);
            }
        }

        void DeleteData(String maSinhVien)
        {
            int idsv = SelectSinhVien(maSinhVien).idSinhVien;
            if (SelectSinhVien(maSinhVien).idLop != null)
            {
                SinhVien sinhVien = db.SinhVien.Find(idsv);
                sinhVien.idLop = null;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Sinh viên " + maSinhVien + " không có lớp");
            }
        }

        void CheckNotNull()
        {
            if (lbMSV.Text == "")
            {
                MessageBox.Show("Chưa chọn sinh viên");
            }
        }

        #endregion

        #region events
        private void cbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGVLopSV();
        }

        private void cbNamNhaphoc_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGVLopSV();
            LoadDGVClassNull();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding(dgvLop.DataSource);
        }

        private void dgvSVKL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding(dgvSVKL.DataSource);
        }

        private void LopGVForm_Resize(object sender, EventArgs e)
        {
            int width = ClientSize.Width;

            groupBox2.Width = (width - groupBox1.Width - 8) / 2;
            groupBox3.Width = (width - groupBox1.Width - 8) / 2;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            CheckNotNull();
            AddData(lbMSV.Text, cbLop.SelectedValue.ToString());
            ClearBinding();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            CheckNotNull();
            DeleteData(lbMSV.Text);
            ClearBinding();
        }
        #endregion

    }
}
