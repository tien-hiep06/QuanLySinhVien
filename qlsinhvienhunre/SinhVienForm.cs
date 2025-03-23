using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienHunre
{
    public partial class SinhVienForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public SinhVienForm()
        {
            InitializeComponent();
            LoadData();
        }
        #region methods

        void LoadData()
        {
            LoadYears();
            LoadDGV();       
        }
        void LoadDGV()
        {
            int namNhapHoc = selectComboboxValue(cbNamNhapHoc);
            // Lấy dữ liệu từ database

            var result = from c in db.SinhVien
                         where c.idSinhVien > 0 && c.namNhapHoc == namNhapHoc
                         select new
                         {
                             maSinhVien = c.maSinhVien,
                             hotenSinhVien = c.hotenSinhVien,
                             maLop = c.Lop.maLop,
                             ngaySinh = c.ngaySinh,
                             gioiTinh = c.gioiTinh,
                             namNhapHoc = c.namNhapHoc,
                         };

            dGVSinhVien.DataSource = result.ToList();
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

        void AddBinding(DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu DataSource của DataGridView là null thì return
            if (dGVSinhVien.DataSource == null) return;
            // Kiểm tra nếu có dữ liệu trong DataGridView gắn dữ liệu cho các control
            else
            {
                tbMaSV.DataBindings.Add("Text", dGVSinhVien.DataSource, "maSinhVien", true, DataSourceUpdateMode.Never);
                tbHoTen.DataBindings.Add("Text", dGVSinhVien.DataSource, "hotenSinhVien", true, DataSourceUpdateMode.Never);
                dTPNgaySinh.DataBindings.Add("Value", dGVSinhVien.DataSource, "ngaySinh", true, DataSourceUpdateMode.Never);
                if (e.RowIndex >= 0 && e.RowIndex < dGVSinhVien.Rows.Count)
                {
                    // Lấy giá trị giới tính từ dòng được chọn
                    string gioiTinh = dGVSinhVien.Rows[e.RowIndex].Cells["gioiTinh"].Value.ToString();

                    // Kiểm tra giới tính và chọn RadioButton tương ứng
                    if (gioiTinh == "Nam")
                    {
                        nam.Checked = true;
                    }
                    else if (gioiTinh == "Nữ")
                    {
                        nu.Checked = true;
                    }
                }
            }
        }
        void ClearBinding()
        {
            // Xóa dữ liệu của các control
            tbMaSV.DataBindings.Clear();
            tbHoTen.DataBindings.Clear();
            dTPNgaySinh.DataBindings.Clear();
        }
        
        int selectComboboxValue(ComboBox cb)
        {
            int value;
            if (!int.TryParse(cb.SelectedValue?.ToString(), out value))
            {
                value = 0;
            }
            return value;
        }

        SinhVien SelectData(String maSinhVien)
        {
            SinhVien sinhVien = db.SinhVien.Where(p => p.maSinhVien == maSinhVien).SingleOrDefault();
            return sinhVien;
        }

        void AddData()
        {
            // Lấy giá trị của RadioButton được chọn
            string selectedValue = null;
            foreach (RadioButton radioButton in panelGioiTinh.Controls)
            {
                if (radioButton.Checked)
                {
                    selectedValue = radioButton.Text;
                    break;

                }
            }
            // Lấy lớp từ combobox
            SinhVien sinhVien = new SinhVien()
            {
                hotenSinhVien = tbHoTen.Text,
                ngaySinh = dTPNgaySinh.Value.Date,
                gioiTinh = selectedValue,
                namNhapHoc = (int)cbNamNhapHoc.SelectedValue
            };

            try
            {
                db.SinhVien.Add(sinhVien);
                db.SaveChanges();

                SinhVien sinhVienUpdate = db.SinhVien.Find(sinhVien.idSinhVien);
                sinhVienUpdate.maSinhVien = ("SV" + sinhVien.idSinhVien).ToString();
                db.SaveChanges();

                AddAcc(sinhVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm sinh viên thất bại! Lỗi: " + ex.Message);
            }
        }

        void AddAcc(SinhVien sinhVien)
        {
            NguoiDung nguoiDung = new NguoiDung()
            {
                idSinhVien = sinhVien.idSinhVien,
                matKhau = sinhVien.idSinhVien + sinhVien.maSinhVien,
                chucVu = "SV"
            };
            db.NguoiDung.Add(nguoiDung);
            db.SaveChanges();
            MessageBox.Show("Thêm sinh viên và người dùng thành công!");
        }

        void EditData(String maSinhVien)
        {
            SinhVien sinhVien = db.SinhVien.Find(SelectData(maSinhVien).idSinhVien);
            if (sinhVien != null)
            {
                string selectedValue = null;
                foreach (RadioButton radioButton in panelGioiTinh.Controls)
                {
                    if (radioButton.Checked)
                    {
                        selectedValue = radioButton.Text;
                        break;
                    }
                }
                sinhVien.hotenSinhVien = tbHoTen.Text;
                sinhVien.ngaySinh = dTPNgaySinh.Value.Date;
                sinhVien.gioiTinh = selectedValue.ToString();
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sửa thông tin sinh viên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin sinh viên thất bại! Lỗi: " + ex.Message);
                }
            };
        }

        void DeleteData(String maSinhVien)
        {
            if (!db.ThamGiaLopHoc.Any(p => p.SinhVien.maSinhVien == maSinhVien))
            {
                SinhVien sinhVien = db.SinhVien.Where(p => p.maSinhVien == maSinhVien).SingleOrDefault();
                NguoiDung nguoiDung = db.NguoiDung.Where(p => p.idSinhVien == sinhVien.idSinhVien).SingleOrDefault();
                try
                {
                    db.NguoiDung.Remove(nguoiDung);
                    db.SinhVien.Remove(sinhVien);
                    db.SaveChanges();
                    MessageBox.Show("Xóa sinh viên và người dùng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa sinh viên thất bại! Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Sinh viên " + maSinhVien + " đã tham gia lớp học phần, không thể xóa sinh viên!");
            }
        }

        void ResetData()
        {
            tbMaSV.Clear();
            tbHoTen.Clear();
            dTPNgaySinh.Value = DateTime.Now;
            nam.Checked = false;
            nu.Checked = false;
        }

        Boolean CheckNotNull()
        {
            if (string.IsNullOrEmpty(tbHoTen.Text) || (!nam.Checked && !nu.Checked))
                return false;
            else
                return true;
        }

        #endregion

        #region event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckNotNull())
            {
                AddData();
                LoadDGV();
            } else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetData();
            LoadDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaSV.Text))
            {
                DeleteData(tbMaSV.Text);
                LoadDGV();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaSV.Text) && CheckNotNull())
            {
                EditData(tbMaSV.Text);
                LoadDGV();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để chỉnh sửa!");
            }
        }

        private void cbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dGVSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding(e);
        }

        private void cbNamNhapHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }
        #endregion
    }
}
