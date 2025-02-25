using QLSinhVienHunre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlisinhvienHUNRE
{
    public partial class LopHocPhanForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public LopHocPhanForm()
        {
            InitializeComponent();
            LoadData();
        }
        #region methods

        void AddBinding()
        {
            if (dGVLopHP.DataSource == null) return;
            else
            {
                tbMaHP.DataBindings.Add("Text", dGVLopHP.DataSource, "maLopHocPhan", true, DataSourceUpdateMode.Never);
                dTPNamHoc.DataBindings.Add("Value", dGVLopHP.DataSource, "namHoc", true, DataSourceUpdateMode.Never);
                dTPNamHoc.DataBindings[0].Format += (s, e) =>
                {
                    if (e.Value != null && e.DesiredType == typeof(DateTime))
                    {
                        int namHoc = (int)e.Value;
                        e.Value = new DateTime(namHoc, 1, 1); // Giả sử năm nhập học là ngày 1 tháng 1 của năm đó
                    }
                };
                tbMoTa.DataBindings.Add("Text", dGVLopHP.DataSource, "moTa", true, DataSourceUpdateMode.Never);
                tbGioiHSV.DataBindings.Add("Text", dGVLopHP.DataSource, "gioiHanSinhVien", true, DataSourceUpdateMode.Never);
                cbTenGV.DataBindings.Add("Text", dGVLopHP.DataSource, "hotenGiangVien", true, DataSourceUpdateMode.Never);
                cbTenMH.DataBindings.Add("Text", dGVLopHP.DataSource, "tenMonHoc", true, DataSourceUpdateMode.Never);

            }
        }
        int SelectIdLopHocPhan(String maLopHocPhan)
        {
            int lopHocPhan = db.LopHocPhan.Where(p => p.maLopHocPhan == maLopHocPhan).Select(p => p.idLopHocPhan).SingleOrDefault();
            return lopHocPhan;
        }
        int SelectIdMonHoc(String cbMonHoc)
        {
            int monHoc = db.MonHoc.Where(p => p.maMonHoc == cbMonHoc || p.tenMonHoc == cbMonHoc).Select(p => p.idMonHoc).SingleOrDefault();
            return monHoc;
        }
        int SelectIdGiangVien(String cbGiangVien)
        {
            int giangVien = db.GiangVien.Where(p => p.maGiangVien == cbGiangVien || p.hotenGiangVien == cbGiangVien).Select(p => p.idGiangVien).SingleOrDefault();
            return giangVien;
        }
        void ClearBinding()
        {
            tbMaHP.DataBindings.Clear();
            dTPNamHoc.DataBindings.Clear();
            tbMoTa.DataBindings.Clear();
            tbGioiHSV.DataBindings.Clear();
            cbTenMH.DataBindings.Clear();
            cbTenGV.DataBindings.Clear();
        }
        void LoadData()
        {
            var result = from c in db.LopHocPhan
                         where c.idLopHocPhan > -1
                         select new
                         {
                             maLopHocPhan = c.maLopHocPhan,
                             namHoc = c.namHoc,
                             moTa = c.moTa,
                             hocKy = c.hocKy,
                             tenMonHoc = c.MonHoc.tenMonHoc,
                             gioiHanSinhVien = c.gioiHanSinhVien,
                             hotenGiangVien = c.GiangVien.hotenGiangVien,
                          
                         };
            dGVLopHP.DataSource = result.ToList();
            cbTenGV.DataSource = db.GiangVien.Select(p => p.hotenGiangVien).ToList();
            cbTenMH.DataSource = db.MonHoc.Select(p=>p.tenMonHoc).ToList();

        }
        void AddData()
        {
            int idgv = SelectIdGiangVien(cbTenGV.SelectedValue.ToString());
            int idmh = SelectIdMonHoc(cbTenMH.SelectedValue.ToString());
            int selectedValue = 0;
            foreach (RadioButton radioButton in panelHocKi.Controls)
            {
                if (radioButton.Checked)
                {
                    if (radioButton.Text == "I")
                    {
                        selectedValue = 1;
                        break;
                    }
                    else if (radioButton.Text == "II")
                    {
                        selectedValue = 2;
                        break;
                    }
                }
            }
            LopHocPhan lopHocPhan = new LopHocPhan()
            {
                namHoc = dTPNamHoc.Value.Year,
                moTa = tbMoTa.Text,
                hocKy = selectedValue,
                gioiHanSinhVien = Convert.ToInt32(tbGioiHSV.Text),
                idGiangVien = idgv,
                idMonHoc = idmh
            };

            try
            {
                db.LopHocPhan.Add(lopHocPhan);
                db.SaveChanges();

                String mamh = db.MonHoc.Where(p => p.idMonHoc == idmh).Select(p => p.maMonHoc).FirstOrDefault();
                LopHocPhan lopHocPhanUpdate = db.LopHocPhan.Find(lopHocPhan.idLopHocPhan);
                lopHocPhanUpdate.maLopHocPhan = lopHocPhan.namHoc.ToString() + mamh;
                db.SaveChanges();

                MessageBox.Show("Thêm Lớp Học Phần Thành Công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Lớp Học Phần thất bại! Lỗi: " + ex.Message);
            }
        }


        void EditData(String maLopHocPhan)
        {
            int idlhp = SelectIdLopHocPhan(maLopHocPhan);
            int idgv = SelectIdGiangVien(cbTenGV.SelectedValue.ToString());
            int idmh = SelectIdMonHoc(cbTenMH.SelectedValue.ToString());

            LopHocPhan lopHocPhan = db.LopHocPhan.Find(idlhp);

            int selectedValue = 0;
            foreach (RadioButton radioButton in panelHocKi.Controls)
            {
                if (radioButton.Checked)
                {
                    if(radioButton.Text == "I")
                    {
                        selectedValue = 1;
                        break;
                    }                       
                    else if(radioButton.Text == "II")
                    {
                        selectedValue = 2;
                        break;
                    }
                }
            }
            if (lopHocPhan != null)
            {              
                lopHocPhan.moTa = tbMoTa.Text;
                lopHocPhan.hocKy = selectedValue;
                lopHocPhan.namHoc = dTPNamHoc.Value.Year;
                lopHocPhan.gioiHanSinhVien = Convert.ToInt32(tbGioiHSV.Text);
                lopHocPhan.idMonHoc = idmh;
                lopHocPhan.idGiangVien = idgv;

                db.SaveChanges();
                MessageBox.Show("Sửa thông tin Lớp Học Phần thành công!");
                ResetData();
            };
        }
        void DeleteData(String maLopHocPhan)
        {
            if (!db.ThamGiaLopHoc.Any(p => p.LopHocPhan.maLopHocPhan == maLopHocPhan))
            {
                int idlhp = SelectIdLopHocPhan(maLopHocPhan);
                LopHocPhan lopHocPhan = db.LopHocPhan.Where(p => p.idLopHocPhan == idlhp).SingleOrDefault();

                db.LopHocPhan.Remove(lopHocPhan);
                db.SaveChanges();
                MessageBox.Show("Xóa lớp học phần thành công!");
                ResetData();
            }
            else
            {
                MessageBox.Show("Lớp học phần " + maLopHocPhan + " đã có sing viên tham gia , không thể xóa lớp học phần!");
            }
        }

        void ResetData()
        {
            tbMaHP.Clear();
            tbMoTa.Clear();
            tbGioiHSV.Clear();
            dTPNamHoc.Value = DateTime.Now;
            foreach (RadioButton radioButton in panelHocKi.Controls)
            {
                radioButton.Checked = false;
            }
            cbTenGV.Text = "";
            cbTenMH.Text = "";
        }

        Boolean CheckNotNull()
        {
            int GioiHSVvalue;
            if ( string.IsNullOrEmpty(tbMoTa.Text)
                || string.IsNullOrEmpty(tbGioiHSV.Text)
                || string.IsNullOrEmpty (cbTenGV.Text)
                || string.IsNullOrEmpty(cbTenMH.Text)
                || (rdKi1.Checked == false && rdKi2.Checked == false)
                || !int.TryParse(tbGioiHSV.Text, out GioiHSVvalue))
                return false;        
            else
                return true;
        }
        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaHP.Text) && CheckNotNull())
            {
                EditData(tbMaHP.Text.ToString());
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin để sửa và kiểm tra lại thông tin nhập!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckNotNull())
            {
                AddData();
                LoadData();
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và kiểm tra thông tin nhập!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaHP.Text))
            {
                DeleteData(tbMaHP.Text.ToString());
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin để xóa!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void btThamGiaHocPhan_Click(object sender, EventArgs e)
        {
            ThamGiaHocPhanForm thamGiaHocPhanForm = new ThamGiaHocPhanForm();
            thamGiaHocPhanForm.ShowDialog();
        }

        private void dGVLopHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVLopHP.Rows.Count)
            {
                // Lấy giá trị giới tính từ dòng được chọn
                string hocKy = dGVLopHP.Rows[e.RowIndex].Cells["hocKy"].Value.ToString();

                // Kiểm tra giới tính và chọn RadioButton tương ứng
                if (hocKy == "1")
                {
                    rdKi1.Checked = true;
                }
                else if (hocKy == "2")
                {
                    rdKi2.Checked = true;
                }
            }
            ClearBinding();
            AddBinding();
        }
    }
}
