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
    public partial class ThamGiaHocPhanForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public ThamGiaHocPhanForm()
        {
            InitializeComponent();
            LoadData();
        }
        #region methods
        void LoadData()
        {
            cbMaLopHocPhan.DataSource = db.LopHocPhan.Select(p => p.maLopHocPhan).ToList();
            cbMaLop.DataSource = db.Lop.Select(p => p.maLop).ToList();
            LoadDGV();
        }
        void LoadDGV()
        {
            if (cbMaLopHocPhan.SelectedValue != null)
            {
                var result = from c in db.ThamGiaLopHoc
                             where c.LopHocPhan.maLopHocPhan == cbMaLopHocPhan.SelectedValue
                             select new
                             {
                                 maSinhVien = c.SinhVien.maSinhVien,
                                 hotenSinhVien = c.SinhVien.hotenSinhVien,
                                 ngaySinh = c.SinhVien.ngaySinh,
                                 maLop = c.SinhVien.Lop.maLop,
                             };
                dGVThamGia.DataSource = result.ToList();

                var lopHocPhanId = SelectIdLopHocPhan();
                var lopId = SelectIdLop();

                if (lopHocPhanId != null)
                {
                    var result2 = from c in db.SinhVien
                                  where !db.ThamGiaLopHoc.Any(p => p.idSinhVien == c.idSinhVien && p.idLopHocPhan == lopHocPhanId) && c.idLop == lopId
                                  select new
                                  {
                                      maSinhVien = c.maSinhVien,
                                      hotenSinhVien = c.hotenSinhVien,
                                      ngaySinh = c.ngaySinh,
                                      maLop = c.Lop.maLop,
                                  };
                    dGVSinhVien.DataSource = result2.ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp học phần tương ứng.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn lớp học phần.");
            }
        }
        void AddBinding(object dGV)
        {
            tbMaSinhVien.DataBindings.Add("Text", dGV, "maSinhVien", true, DataSourceUpdateMode.Never);
        }
        void ClearBinding()
        {
            tbMaSinhVien.DataBindings.Clear();
        }
        int SelectIdLopHocPhan()
        {
            if (cbMaLopHocPhan.SelectedValue != null)
            {
                int result = db.LopHocPhan.Where(p => p.maLopHocPhan == cbMaLopHocPhan.SelectedValue).Select(p => p.idLopHocPhan).SingleOrDefault();
                return result;
            }
            else { return -1; }
        }

        int SelectIdSinhVien()
        {
            if (tbMaSinhVien.Text != null)
            {
                int result = db.SinhVien
                    .Where(p => p.maSinhVien == tbMaSinhVien.Text)
                    .Select(p => p.idSinhVien)
                    .SingleOrDefault();
                return result;
            }
            else { return -1; }
        }
        int SelectIdLop()
        {
            if(cbMaLop.SelectedValue != null)
            {
                int result = db.Lop
                    .Where(p => p.maLop == cbMaLop.SelectedValue)
                    .Select (p => p.idLop).SingleOrDefault();
                return result;
            }else { return -1; }
        }

        void AddSingleData()
        {
            ThamGiaLopHoc thamGiaLopHoc = new ThamGiaLopHoc()
            {
                idSinhVien = SelectIdSinhVien(),
                idLopHocPhan = SelectIdLopHocPhan()
            };
            db.ThamGiaLopHoc.Add(thamGiaLopHoc);
            db.SaveChanges();
        }
        void AddMultiData()
        {
            int sil = SelectIdLop();
            int sisv = SelectIdSinhVien();
            int silhp = SelectIdLopHocPhan();
            var listSinhVien = db.SinhVien.Where(p => p.idLop == sil).ToList();
            foreach (var sinhVien in listSinhVien)
            {
                if(!db.ThamGiaLopHoc.Any(p => p.idSinhVien == sinhVien.idSinhVien && p.idLopHocPhan == silhp))
                {
                    ThamGiaLopHoc thamGiaLopHoc = new ThamGiaLopHoc()
                    {
                        idSinhVien = sinhVien.idSinhVien,
                        idLopHocPhan = silhp
                    };
                    db.ThamGiaLopHoc.Add(thamGiaLopHoc);
                    db.SaveChanges();
                }
 
            }

            MessageBox.Show("Đã thêm lớp " + cbMaLop.SelectedValue + " vào " + cbMaLopHocPhan.SelectedValue);
        }

        void DeleteData ()
        {
            if (SelectIdLopHocPhan() > 0 && SelectIdSinhVien() > 0)
            {
                ThamGiaLopHoc thamGiaLopHoc = db.ThamGiaLopHoc.FirstOrDefault(p => p.idLopHocPhan == SelectIdLopHocPhan() && p.idSinhVien == SelectIdSinhVien());
                if (thamGiaLopHoc != null)
                {
                    db.ThamGiaLopHoc.Remove(thamGiaLopHoc);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Sinh viên " + tbMaSinhVien.Text + " không có trong lớp học phần " + cbMaLopHocPhan.SelectedValue.ToString());
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa dữ liệu vì dữ liệu sinh viên hoặc lớp học phần không tồn tại.");
            }
        }

        #endregion
        #region events

        private void btDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddSingleData();
            LoadData();
            ClearBinding();
        }
        private void btAddAll_Click(object sender, EventArgs e)
        {
            AddMultiData();
            LoadData();
            ClearBinding();
        }

        private void dGVSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding(dGVSinhVien.DataSource);
        }

        private void dGVThamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding(dGVThamGia.DataSource);
        }

        private void cbMaLopHocPhan_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void cbMaLop_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }
        #endregion
    }
}
