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
    public partial class LopForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public LopForm()
        {
            InitializeComponent();
            LoadData();
            LoadYears();
        }
        #region methods
        void LoadData()
        {
            cbMaNganh.DataSource = db.NganhHoc.Select(p => p.maNganhHoc).ToList();
            LoadDGVLop();
            LoadDGVGV();
        }
        void LoadDGVLop()
        {
            int namNhapHoc = selectComboboxValue(cbNamNhapHoc);

            var result = from c in db.Lop
                         where c.NganhHoc.maNganhHoc == cbMaNganh.SelectedValue
                         && c.namNhapHoc == namNhapHoc
                         select new
                         {
                             maLop = c.maLop,
                             maNganhHoc = c.NganhHoc.maNganhHoc,
                             tenNganhHoc = c.NganhHoc.tenNganhHoc,
                             maGiangVien = c.GiangVien.maGiangVien,
                             hotenGiangVien = c.GiangVien.hotenGiangVien,
                             namNhapHoc = c.namNhapHoc
                         };
            dGVLop.DataSource = result.ToList();
        }
        void LoadDGVGV()
        {
            var result = from c in db.GiangVien
                         select new
                         {
                             maGiangVien = c.maGiangVien,
                             hotenGiangVien = c.hotenGiangVien,
                             ngaySinh = c.ngaySinh
                         };
            dGVGiangVien.DataSource = result.ToList();
        }
        private void LoadYears()
        {
            int startYear = 2000;
            int currentYear = DateTime.Now.Year;

            // Tạo danh sách object chứa Text và Value
            var years = new List<object>();
            for (int year = startYear; year <= currentYear; year++)
            {
                years.Add(new { Text = year.ToString(), Value = year });
            }

            cbNamNhapHoc.DataSource = years; // Gán danh sách vào ComboBox
            cbNamNhapHoc.DisplayMember = "Text";  // Hiển thị năm
            cbNamNhapHoc.ValueMember = "Value";  // Giá trị thực sự

            cbNamNhapHoc.SelectedValue = currentYear; // Đặt giá trị mặc định là năm hiện tại

        }

        void AddBinding(object dGV)
        {
            if (dGV == dGVLop.DataSource)
            {
                tbMaLop.DataBindings.Add("Text", dGV, "maLop", true, DataSourceUpdateMode.Never);
            }
            tbMaGiangVien.DataBindings.Add("Text", dGV, "maGiangVien", true, DataSourceUpdateMode.Never);
        }
        void ClearBinding()
        {
            tbMaLop.DataBindings.Clear();
            tbMaGiangVien.DataBindings.Clear();
        }

        int selectComboboxValue(ComboBox cb)
        {
            int value;
            if (!int.TryParse(cb.SelectedValue?.ToString(), out value))
            {
                value = 0; // Giá trị mặc định nếu không lấy được năm
            }
            return value;
        }

        NganhHoc SelectNganhHoc(String maNganh)
        {
            NganhHoc result = db.NganhHoc.Where(p => p.maNganhHoc == maNganh).SingleOrDefault();
            return result;
        }

        GiangVien SelectGiangVien(String maGiangVien)
        {
            GiangVien result = db.GiangVien.Where(p => p.maGiangVien == maGiangVien).SingleOrDefault();
            return result;
        }

        Lop SelectLop(String maLop)
        {
            Lop result = db.Lop.Where(p => p.maLop == tbMaLop.Text).SingleOrDefault();
            return result;

        }

        void AddData(String maGiangVien, String maNganhHoc)
        {
            int count = db.Lop.Where(p => p.NganhHoc.maNganhHoc == maNganhHoc && p.namNhapHoc == selectComboboxValue(cbNamNhapHoc)).Count() + 1;
            Lop lop = new Lop()
            {
               idNganhHoc = SelectNganhHoc(maNganhHoc).idNganhHoc,
               idGiangVien = SelectGiangVien(maGiangVien).idGiangVien
            };
            db.Lop.Add(lop);
            db.SaveChanges();

            Lop lopUpdate = db.Lop.Find(lop.idLop);
            lopUpdate.maLop = cbMaNganh.SelectedValue.ToString() + count;
            db.SaveChanges();
            MessageBox.Show("Thêm lớp thành công.");
        }

        void EditData(String maLop, String maGiangVien, String maNganhHoc)
        {
            Lop lop = db.Lop.Find(SelectLop(maLop).idLop);
            lop.idGiangVien = SelectGiangVien(maGiangVien).idGiangVien;
            lop.idNganhHoc = SelectNganhHoc(maNganhHoc).idNganhHoc;   
            db.SaveChanges();
            MessageBox.Show("Sửa thông tin lớp thành công.");
        }

        void DeleteData(String maLop)
        {
           if (!db.SinhVien.Any(p => p.Lop.maLop == maLop))
           {
                Lop lopDel = db.Lop.Find(SelectLop(maLop).idLop);
                db.Lop.Remove(lopDel);
                db.SaveChanges();
                MessageBox.Show("Xóa lớp thành công.");
           }
           else
           {
                MessageBox.Show("Không thể xóa lớp có sinh viên");
           }
        }

        void ResetData()
        {
            tbMaGiangVien.Clear();
            tbMaLop.Clear();
        }

        Boolean CheckNotNull()
        {
            if (/*string.IsNullOrEmpty(tbMaLop.Text) ||*/ string.IsNullOrEmpty(tbMaGiangVien.Text))
                return false;
            else
                return true;
        }

        #endregion
        #region event
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (CheckNotNull())
            {
                AddData(tbMaGiangVien.Text, cbMaNganh.SelectedValue.ToString());
                LoadDGVLop();
                ClearBinding();
                ResetData();
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaLop.Text))
            {
                EditData(tbMaLop.Text, tbMaGiangVien.Text, cbMaNganh.SelectedValue.ToString());
                LoadDGVLop();
                ClearBinding();
                ResetData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp để sửa!");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaLop.Text))
            {
                DeleteData(tbMaLop.Text);
                LoadDGVLop();
                ClearBinding();
                ResetData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp để xóa!");
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ClearBinding();
            ResetData();
        }

        private void cbMaNganh_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGVLop();
        }

        private void dGVGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding(dGVGiangVien.DataSource);
        }

        private void dGVLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            ClearBinding();
            AddBinding(dGVLop.DataSource);
        }

        private void cbNamNhapHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGVLop();
        }
        #endregion
    }
}
