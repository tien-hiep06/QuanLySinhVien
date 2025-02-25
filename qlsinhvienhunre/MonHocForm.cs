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
    public partial class MonHocForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public MonHocForm()
        {
            InitializeComponent();
            LoadData();
        }
       
        void AddBinding()
        {
            if (dGVMonHoc.DataSource == null) 
                return;
            else
            {
                tbMaMH.DataBindings.Add("Text", dGVMonHoc.DataSource, "maMonHoc", true, DataSourceUpdateMode.Never);
                tbTenMH.DataBindings.Add("Text", dGVMonHoc.DataSource, "tenMonHoc", true, DataSourceUpdateMode.Never);
                tbSoTC.DataBindings.Add("Text", dGVMonHoc.DataSource, "soTinChi", true, DataSourceUpdateMode.Never);
                dTPNamBD.DataBindings.Add("Value", dGVMonHoc.DataSource, "namBatDau", true, DataSourceUpdateMode.Never);
                dTPNamBD.DataBindings[0].Format += (s, e) =>
                {
                    if (e.Value != null && e.DesiredType == typeof(DateTime))
                    {
                        int namBatDau = (int)e.Value;
                        e.Value = new DateTime(namBatDau, 1, 1); // Giả sử năm nhập học là ngày 1 tháng 1 của năm đó
                    }
                };
                tbMoTaMH.DataBindings.Add("Text", dGVMonHoc.DataSource, "moTaMonHoc", true, DataSourceUpdateMode.Never);
                cbHTDG.DataBindings.Add("Text", dGVMonHoc.DataSource, "tenHinhThucDanhGia", true, DataSourceUpdateMode.Never);
            }
        }
        MonHoc SelectData(String maMonHoc)
        {
            MonHoc monHoc = db.MonHoc.Where(p => p.maMonHoc == maMonHoc).SingleOrDefault();
            return monHoc;
        }
        void ClearBinding()
        {
            tbMaMH.DataBindings.Clear();
            tbTenMH.DataBindings.Clear();
            dTPNamBD.DataBindings.Clear();
            tbSoTC.DataBindings.Clear();
            tbMoTaMH.DataBindings.Clear();
            cbHTDG.DataBindings.Clear();
        }
        void LoadData()
        {
            var result = from c in db.MonHoc
                         where c.idMonHoc > 0
                         select new
                         {
                             maMonHoc = c.maMonHoc,
                             tenMonHoc = c.tenMonHoc,
                             soTinChi = c.soTinChi,
                             namBatDau = c.namBatDau,
                             quyDinh = c.quyDinh,
                             moTaMonHoc = c.moTaMonHoc,
                             tenHinhThucDanhGia=c.HinhThuc.tenHinhThucDanhGia
                         };
            dGVMonHoc.DataSource = result.ToList();
            cbHTDG.DataSource = db.HinhThuc.Select(p => p.tenHinhThucDanhGia).ToList();
        }
        void AddData()
        {
            string selectedValue = null;

            foreach (RadioButton radioButton in panelQuyDnh.Controls)
            {
                if (radioButton.Checked)
                {
                    selectedValue = radioButton.Text;
                    break;
                }
            }

            MonHoc monHoc = new MonHoc()
            {
                maMonHoc =new string(tbTenMH.Text.Where(char.IsUpper).ToArray()),
                tenMonHoc = tbTenMH.Text,
                soTinChi = Convert.ToInt32(tbSoTC.Text),
                namBatDau = dTPNamBD.Value.Year,
                quyDinh = selectedValue,
                moTaMonHoc = tbMoTaMH.Text,
                hinhThucDanhGia = db.HinhThuc.Where(p => p.tenHinhThucDanhGia == cbHTDG.SelectedValue).Select(p => p.hinhThucDanhGia).SingleOrDefault()
            };

            if (db.MonHoc.Where(p => p.maMonHoc == monHoc.maMonHoc).Any())
            {
                MessageBox.Show("Mã môn học này đã tồn tại");

            }
            else
            {
                db.MonHoc.Add(monHoc);
                db.SaveChanges();

                MessageBox.Show("Thêm Môn Học Thành Công!");
                ResetData();
            }


        }

        void EditData(String maMonHoc)
        {
            string oldMH = SelectData(maMonHoc).maMonHoc;
            string newMH = new string(tbTenMH.Text.Where(char.IsUpper).ToArray());

            MonHoc monHoc = db.MonHoc.Find(SelectData(maMonHoc).idMonHoc);
            string selectedValue = null;

            foreach (RadioButton radioButton in panelQuyDnh.Controls)
            {
                if (radioButton.Checked)
                {
                    selectedValue = radioButton.Text;
                    break;
                }
            }

            monHoc.maMonHoc = newMH;
            monHoc.tenMonHoc = tbTenMH.Text;
            monHoc.soTinChi = Convert.ToInt32(tbSoTC.Text);
            monHoc.namBatDau = dTPNamBD.Value.Year;
            monHoc.quyDinh = selectedValue;
            monHoc.moTaMonHoc = tbMoTaMH.Text;
            monHoc.hinhThucDanhGia = db.HinhThuc.Where(p => p.tenHinhThucDanhGia == cbHTDG.SelectedValue).Select(p => p.hinhThucDanhGia).SingleOrDefault();

            if (db.MonHoc.Any(p => p.maMonHoc == monHoc.maMonHoc) && oldMH != newMH)
            {
                MessageBox.Show("Mã môn học này đã tồn tại");
            }
            else
            {
                db.SaveChanges();
                MessageBox.Show("Sửa thông tin môn học thành công!");
                ResetData();
            }
        }

        void DeleteData(String maMonHoc)
        {

            if(db.LopHocPhan.Any(p=>p.MonHoc.maMonHoc == maMonHoc))
                MessageBox.Show("Môn học đã có trong lớp học phần!");
            else if(db.PhanChiaMonHoc.Any(p=>p.MonHoc.maMonHoc== maMonHoc))
                MessageBox.Show("Môn học đã có ngành học!");
            else 
            { 
                db.MonHoc.Remove(SelectData(maMonHoc));
                db.SaveChanges();
                MessageBox.Show("Xóa môn học thành công!");
                ResetData();
            }
                
        }

        void ResetData()
        {
            tbMaMH.Clear();
            tbMoTaMH.Clear();
            dTPNamBD.Value = DateTime.Now;
            foreach (RadioButton radioButton in panelQuyDnh.Controls)
            {
                radioButton.Checked = false;
            }
            tbSoTC.Clear();
            tbTenMH.Clear();
            cbHTDG.Text = "";
        }

        Boolean CheckNotNull()
        {
            int soTinChiValue;
            if (string.IsNullOrEmpty(tbMaMH.Text) 
                || string.IsNullOrEmpty(tbTenMH.Text) 
                || string.IsNullOrEmpty(tbSoTC.Text)
                || (tuchon.Checked == false && batbuoc.Checked == false)
                || !int.TryParse(tbSoTC.Text, out soTinChiValue)) {
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckNotNull())
            {
                AddData();
                LoadData();
            }
            else
                MessageBox.Show("Thêm thất bại, vui lòng điền đầy đủ thông tin và kiểm tra thông tin thêm!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaMH.Text) && CheckNotNull())
            {
                EditData(tbMaMH.Text);
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học để sửa và điền đầy đủ thông tin!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaMH.Text))
            {
                DeleteData(tbMaMH.Text);
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học để xóa!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearBinding();
            ResetData();        
        }

        private void dGVSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding();
            if (e.RowIndex >= 0 && e.RowIndex < dGVMonHoc.Rows.Count)
            {
                // Lấy giá trị giới tính từ dòng được chọn
                string quyDinh = dGVMonHoc.Rows[e.RowIndex].Cells["quyDinh"].Value.ToString();

                // Kiểm tra giới tính và chọn RadioButton tương ứng
                if (quyDinh == "Bắt buộc")
                {
                    batbuoc.Checked = true;
                }
                else if (quyDinh == "Tự chọn")
                {
                    tuchon.Checked = true;
                }
            }
        }
    }
}