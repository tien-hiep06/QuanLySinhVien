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
    public partial class ThongTinSinhVienForm : Form
    {
        public string idSV;
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public ThongTinSinhVienForm(String idSinhVien)
        {
            InitializeComponent();
            idSV = idSinhVien;
        }
       void loadData()
        {
            String maSinhVien = db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.maSinhVien).SingleOrDefault();
            tbMaSV.Text = maSinhVien;
            String hotenSinhVien = db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.hotenSinhVien).SingleOrDefault();
            tbHoTen.Text = hotenSinhVien;
            String ngaysinh = db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.ngaySinh.Value.ToString()).SingleOrDefault();
            tbNgaySinh.Text = ngaysinh;
            String gioitinh = db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.gioiTinh).SingleOrDefault();
            tbGioiTinh.Text = gioitinh;
            String lop = db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.Lop.maLop).SingleOrDefault();
            tbLopHoc.Text = lop;
            String nghanhhoc = db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.Lop.NganhHoc.tenNganhHoc).SingleOrDefault();
            tbNganhHoc.Text = nghanhhoc;


        }
        SinhVien SelectData(String maSinhVien)
        {
            SinhVien sinhVien = db.SinhVien.Where(p => p.maSinhVien == idSV).SingleOrDefault();
            return sinhVien;
        }


        void EditData(String maSinhVien)
        {
            SinhVien sinhVien = db.SinhVien.Find(SelectData(maSinhVien).idSinhVien);
       
            if (sinhVien != null)
            {
       

                sinhVien.hotenSinhVien = tbHoTen.Text;
                DateTime ngaySinh;
                if (DateTime.TryParse(tbNgaySinh.Text, out ngaySinh))
                {
                    sinhVien.ngaySinh = ngaySinh;
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!");
                    return;
                }
                sinhVien.gioiTinh = tbGioiTinh.Text;
             
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

        private void ThôngTinSinhVienForm_Load(object sender, EventArgs e)
        {
         loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditData(tbMaSV.Text);
            loadData();
        }

 
    }
}
