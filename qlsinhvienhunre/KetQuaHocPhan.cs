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
    public partial class KetQuaHocPhanForm : Form
    {
        public string maGV;
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();

        public KetQuaHocPhanForm(String maGiangVien)
        {
            maGV = maGiangVien;
            InitializeComponent();
            LoadDataDgvSinhVien();
            AddBinding();
        }


        void AddBinding()
        {
            if (dGVSinhVien.DataSource == null) return;
            else
            {
                tbMLHP.DataBindings.Add("Text", dGVSinhVien.DataSource, "maLopHocPhan", true, DataSourceUpdateMode.Never);
                tbMSV.DataBindings.Add("Text", dGVSinhVien.DataSource, "maSinhVien", true, DataSourceUpdateMode.Never);
                tbDiemSo.DataBindings.Add("Text", dGVSinhVien.DataSource, "diemSo", true, DataSourceUpdateMode.Never);
                tbDiemChu.DataBindings.Add("Text", dGVSinhVien.DataSource, "diemChu", true, DataSourceUpdateMode.Never);
            }
        }
        void ClearBinding()
        {
            tbMLHP.DataBindings.Clear();
            tbMSV.DataBindings.Clear();
            tbDiemSo.DataBindings.Clear();
            tbDiemChu.DataBindings.Clear();
        }
        void LoadDataDgvSinhVien()
        {
            var result = from c in db.ThamGiaLopHoc
                         where c.LopHocPhan.GiangVien.maGiangVien == maGV
                         select new
                         {
                             maLopHocPhan = c.LopHocPhan.maLopHocPhan,
                             maSinhVien = c.SinhVien.maSinhVien,
                             hotenSinhVien = c.SinhVien.hotenSinhVien,
                             ngaySinh = c.SinhVien.ngaySinh,
                             tenMonHoc = c.LopHocPhan.MonHoc.tenMonHoc,
                             diemSo = c.diemSo,
                             diemChu = c.diemChu
                         };
            dGVSinhVien.DataSource = result.ToList();

        }
        SinhVien SelectIDSV(String maSV)
        {
            SinhVien sinhVien = db.SinhVien.Where(p => p.maSinhVien == maSV).SingleOrDefault();
            return sinhVien;
        }
        LopHocPhan SelectIDHP(String maHocPhan)
        {
            LopHocPhan lopHocPhan = db.LopHocPhan.Where(p => p.maLopHocPhan == maHocPhan).SingleOrDefault();
            return lopHocPhan;
        }
        void EditData(String malhp, String msv)
        {
            int idlhp = SelectIDHP(malhp).idLopHocPhan;
            int idsv = SelectIDSV(msv).idSinhVien;
            ThamGiaLopHoc thamGiaLopHoc = db.ThamGiaLopHoc.Find(idlhp, idsv);
            thamGiaLopHoc.diemChu = tbDiemChu.Text;
            thamGiaLopHoc.diemSo = Convert.ToDouble(tbDiemSo.Text);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Cập nhật điểm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa điểm thất bại! Lỗi: " + ex.Message);
            }
        }

        private void dGVSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            EditData( tbMLHP.Text,tbMSV.Text);
            LoadDataDgvSinhVien();
        }
    }
}