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
    public partial class TaiKhoanNguoiDung : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public TaiKhoanNguoiDung()
        {
            InitializeComponent();
        }
        #region methods

        void AddBinding()
        {
            if (dGVThongTin.DataSource == null) return;
            else
            {
                 tbID.DataBindings.Add("Text", dGVThongTin.DataSource, "idNguoiDung",true,DataSourceUpdateMode.Never);
                if (cbChucVu.SelectedItem.ToString() == "SV") 
                {
                    tbSV_GV.DataBindings.Add("Text", dGVThongTin.DataSource, "maSinhVien", true, DataSourceUpdateMode.Never); 
                }else if(cbChucVu.SelectedItem.ToString() == "GV")
                {
                    tbSV_GV.DataBindings.Add("Text", dGVThongTin.DataSource, "maGiangVien", true, DataSourceUpdateMode.Never);
                }
                tbMatKhau.DataBindings.Add("Text", dGVThongTin.DataSource, "matKhau", true, DataSourceUpdateMode.Never);
            }
        }
        void ClearBinding()
        {
            tbID.DataBindings.Clear();
            tbSV_GV.DataBindings.Clear();
            tbMatKhau.DataBindings.Clear();
        }
        void LoadData()
        {
            if (cbChucVu.SelectedItem.ToString() == "SV") 
            {
                var result = from c in db.NguoiDung
                             where c.idGiangVien == null && c.idSinhVien != null
                             select new
                             {
                                 idNguoiDung = c.idNguoiDung,
                                 maSinhVien = c.SinhVien.maSinhVien,
                                 matKhau = c.matKhau,
                                 hotenSinhVien = c.SinhVien.hotenSinhVien,
                                 maLop = c.SinhVien.Lop.maLop,
                                 ngaySinh = c.SinhVien.ngaySinh,
                                 gioiTinh = c.SinhVien.gioiTinh
                             };
                dGVThongTin.DataSource = result.ToList();
            }
            else if(cbChucVu.SelectedItem.ToString() == "GV")
            {
                var result = from c in db.NguoiDung
                             where c.idGiangVien != null && c.idSinhVien == null
                             select new
                             {
                                 idNguoiDung = c.idNguoiDung,
                                 maGiangVien = c.GiangVien.maGiangVien,
                                 matKhau = c.matKhau,
                                 hotenGiangVien = c.GiangVien.hotenGiangVien,
                                 ngaySinh = c.GiangVien.ngaySinh,
                                 gioiTinh = c.GiangVien.gioiTinh
                             };
                dGVThongTin.DataSource= result.ToList();
            }
        }

        void EditData(String idNguoiDung)
        {
            NguoiDung nguoiDung = db.NguoiDung.Find(Convert.ToInt32(idNguoiDung));
            nguoiDung.matKhau = tbMatKhau.Text;
            db.SaveChanges();
        }
        #endregion

        private void cbChucVu_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dGVThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbID.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng để chỉnh sửa!");
            }
            else if (string.IsNullOrEmpty(tbMatKhau.Text))
            {
                MessageBox.Show("Vui lòng điền mật khẩu muốn thay đổi!");
            }
            else
            {
                EditData(tbID.Text);
                MessageBox.Show("Cập nhật mật khẩu thành công");
                LoadData();
                ClearBinding();
                AddBinding();
            }
        }

    }
}
