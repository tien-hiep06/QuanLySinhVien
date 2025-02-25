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
    public partial class ChiaMonForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public ChiaMonForm()
        {
            InitializeComponent();
            LoadData();
        }
        #region methods
        void LoadData()
        {
            cbMaNganh.DataSource = db.NganhHoc.Select(p => p.maNganhHoc).ToList();
            LoadDGV();
        }
        void LoadDGV()
        {
            var result = from c in db.PhanChiaMonHoc
                         where c.NganhHoc.maNganhHoc == cbMaNganh.SelectedValue
                         select new
                         {
                             maMonHoc = c.MonHoc.maMonHoc,
                             tenMonHoc = c.MonHoc.tenMonHoc,
                             soTinChi = c.MonHoc.soTinChi,
                             quyDinh = c.MonHoc.quyDinh,
                             tenHinhThucDanhGia = c.MonHoc.HinhThuc.tenHinhThucDanhGia
                         };
            dGVNganhHoc.DataSource = result.ToList();
            NganhHoc selectID = db.NganhHoc.Where(p => p.maNganhHoc == cbMaNganh.SelectedValue).SingleOrDefault();

            var result2 = from c in db.MonHoc
                         where !db.PhanChiaMonHoc.Any(p => p.idMonHoc == c.idMonHoc && p.idNganhHoc == selectID.idNganhHoc)
                         select new
                         {
                             maMonHoc = c.maMonHoc,
                             tenMonHoc = c.tenMonHoc,
                             soTinChi = c.soTinChi,
                             quyDinh = c.quyDinh,
                             tenHinhThucDanhGia = c.HinhThuc.tenHinhThucDanhGia
                         };
            int tongSoTinChi = (int)result2.Sum(m => m.soTinChi);
            dGVMonHoc.DataSource = result2.ToList();
        }
        void AddBinding(object dGV)
        {
            tbMaMon.DataBindings.Add("Text",dGV, "maMonHoc",true,DataSourceUpdateMode.Never);
        }

        void ClearBinding()
        {
            tbMaMon.DataBindings.Clear();
        }

        void AddData(String maMonHoc, String maNganhHoc)
        {
            int idmh = SelectMon(maMonHoc).idMonHoc;
            int idnh = SelectNganh(maNganhHoc).idNganhHoc;
            if (!db.PhanChiaMonHoc.Any(p => p.idMonHoc == idmh && p.idNganhHoc == idnh))
            {
                PhanChiaMonHoc phanChiaMonHoc = new PhanChiaMonHoc()
                {
                    idNganhHoc = SelectNganh(cbMaNganh.SelectedValue.ToString()).idNganhHoc,
                    idMonHoc = SelectMon(tbMaMon.Text).idMonHoc
                };
                db.PhanChiaMonHoc.Add(phanChiaMonHoc);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Môn học " + tbMaMon.Text + " đã có trong ngành " + cbMaNganh.SelectedValue.ToString());
            }
        }

        void DeleteData(String maMonHoc, String maNganhHoc)
        {
            int idmh = SelectMon(maMonHoc).idMonHoc;
            int idnh = SelectNganh(maNganhHoc).idNganhHoc;
            PhanChiaMonHoc phanChiaMonHoc = db.PhanChiaMonHoc.FirstOrDefault(p => p.idMonHoc == idmh && p.idNganhHoc == idnh);
            if (phanChiaMonHoc != null)
            {
                db.PhanChiaMonHoc.Remove(phanChiaMonHoc);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Môn học " + tbMaMon.Text + " không có trong ngành " + cbMaNganh.SelectedValue.ToString());
            }
        }

        NganhHoc SelectNganh (String maNganh)
        {
            NganhHoc nganhHoc = db.NganhHoc.Where(p => p.maNganhHoc == maNganh).SingleOrDefault();
            return nganhHoc;
        }

        MonHoc SelectMon(String maMonHoc)
        {
            MonHoc monHoc = db.MonHoc.Where(p => p.maMonHoc == maMonHoc).SingleOrDefault();
            return monHoc;
        }

        void UpdateData()
        {
            if (!db.PhanChiaMonHoc.Any(p => p.NganhHoc.maNganhHoc == cbMaNganh.SelectedValue))
            {
                MessageBox.Show("Ngành học này chưa có môn");
            }
            else
            {
                int sum = 0;
                int idnh = SelectNganh(cbMaNganh.SelectedValue.ToString()).idNganhHoc;
                foreach (var item in db.PhanChiaMonHoc.Where(p => p.idNganhHoc == idnh).Select(p => p.MonHoc.soTinChi).ToList())
                {
                    sum += Convert.ToInt32(item);
                }
                NganhHoc nganhHoc = db.NganhHoc.Find(idnh);
                nganhHoc.soTinChi = sum;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật số tín chỉ cảu ngành" + cbMaNganh.SelectedValue.ToString());
            }   
        } 
        #endregion

        #region event
        private void cbMaNganh_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaMon.Text) && !string.IsNullOrEmpty(cbMaNganh.SelectedValue.ToString()))
            {
                AddData(tbMaMon.Text, cbMaNganh.SelectedValue.ToString());
                LoadDGV();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn để thêm!");
            }

        }

        private void dGVMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding(dGVMonHoc.DataSource);
        }

        private void dGVNganhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding(dGVNganhHoc.DataSource);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaMon.Text) && !string.IsNullOrEmpty(cbMaNganh.SelectedValue.ToString()))
            {
                DeleteData(tbMaMon.Text, cbMaNganh.SelectedValue.ToString());
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn để xóa!");
            }
        }

        private void btCapNhatTC_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        #endregion
    }
}
