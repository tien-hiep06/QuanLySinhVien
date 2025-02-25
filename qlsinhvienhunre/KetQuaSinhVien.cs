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
    public partial class KetQuaSinhVien : Form
    {
        public string idSV;
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public KetQuaSinhVien(String idSinhVien)
        {
            InitializeComponent();
            idSV = idSinhVien;
            LoadDataDGV();
            LoadGroupboxTTCN();
        }

        void LoadDataDGV()
        {
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
                            moTa = c.LopHocPhan.moTa
                            

                         };
            DGVKetQua.DataSource = result.ToList();


            int tongSoTinChi =(int) result.Sum(c => c.soTinChi);
            tbTSTTL.Text = tongSoTinChi.ToString();

            int tongSoTinChiTichLuy = ((int)db.SinhVien.Where(p => p.maSinhVien == idSV).Select(p => p.Lop.NganhHoc.soTinChi).SingleOrDefault());
            tbTST.Text = tongSoTinChiTichLuy.ToString();
      

        }

        void LoadGroupboxTTCN()
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
    
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataDGV();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            LoadGroupboxTTCN();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
