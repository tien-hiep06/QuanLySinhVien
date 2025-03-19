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
            lbMaSV.Text = maSinhVien;
            String hotenSinhVien = db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.hotenSinhVien).SingleOrDefault();
            lbHoTen.Text = hotenSinhVien;
            String ngaysinh = db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.ngaySinh.Value.ToString()).SingleOrDefault();
            lbNgaySinh.Text = ngaysinh;
            String gioitinh = db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.gioiTinh).SingleOrDefault();
            lbGioiTinh.Text = gioitinh;
            String lop = db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.Lop.maLop).SingleOrDefault();
            lbLopHoc.Text = lop;
            String nghanhhoc = db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.Lop.NganhHoc.tenNganhHoc).SingleOrDefault();
            lbNganhHoc.Text = nghanhhoc;



            var result = from c in db.ThamGiaLopHoc
                         where c.SinhVien.maSinhVien == idSV
                         select new
                         {
                             maLopHocPhan = c.LopHocPhan.maLopHocPhan,
                             tenMonHoc = c.LopHocPhan.MonHoc.tenMonHoc,
                             soTinChi = c.LopHocPhan.MonHoc.soTinChi,
                             hotenGiangVien = c.LopHocPhan.GiangVien.hotenGiangVien,
                             hinhThucDanhGia = c.LopHocPhan.MonHoc.hinhThucDanhGia,
                             diemSo = c.diemSo,
                             diemChu = c.diemChu,
                             moTa = c.LopHocPhan.moTa,
                             maKetQua = c.maKetQua
                         };

            DGVKetQua.DataSource = result.ToList();

            int tongSoTinChi = ((int)db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.Lop.NganhHoc.soTinChi).SingleOrDefault());
            lbTongSoTin.Text = tongSoTinChi.ToString();

            int tongSoTinChiDaTichLuy = (int)result.Where(p=>p.maKetQua == "Đạt").Sum(c => c.soTinChi);
            lbTinChiTichLuy.Text = tongSoTinChiDaTichLuy.ToString();

            float diemHe10 = ((float)result.Where(p => p.maKetQua == "Đạt").Sum(c => c.diemSo)) / ((float)result.Where(p => p.maKetQua == "Đạt").Count());
            lbDiemHe10.Text = diemHe10.ToString();

            float diemHe4 = diemHe10 / tongSoTinChiDaTichLuy;
            lbDiemHe4.Text = diemHe4.ToString("F2");
        }

        SinhVien SelectData(String maSinhVien)
        {
            SinhVien sinhVien = db.SinhVien.Where(p => p.maSinhVien == idSV).SingleOrDefault();
            return sinhVien;
        }


        private void ThôngTinSinhVienForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
