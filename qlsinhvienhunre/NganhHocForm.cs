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
    public partial class NganhHocForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public NganhHocForm()
        {
            InitializeComponent();
            LoadData();
        }
        void AddBinding()
        {
            if (dGVNganhHoc.DataSource == null) return;
            else
            {
                tbMaNH.DataBindings.Add("Text", dGVNganhHoc.DataSource, "maNganhHoc", true, DataSourceUpdateMode.Never);
                tbTenNH.DataBindings.Add("Text", dGVNganhHoc.DataSource, "tenNganhHoc", true, DataSourceUpdateMode.Never);
                tbSoTC.DataBindings.Add("Text", dGVNganhHoc.DataSource, "soTinChi", true, DataSourceUpdateMode.Never);
                dTPNam.DataBindings.Add("Value", dGVNganhHoc.DataSource, "namBatDau", true, DataSourceUpdateMode.Never);
                dTPNam.DataBindings[0].Format += (s, e) =>
                {
                    if (e.Value != null && e.DesiredType == typeof(DateTime))
                    {
                        int namNhapHoc = (int)e.Value;
                        e.Value = new DateTime(namNhapHoc, 1, 1); // Giả sử năm nhập học là ngày 1 tháng 1 của năm đó
                    }
                };
            }
        }
        void ClearBinding()
        {
            tbMaNH.DataBindings.Clear();
            tbTenNH.DataBindings.Clear();
            tbSoTC.DataBindings.Clear();
            dTPNam.DataBindings.Clear();
        }

        NganhHoc SelectData(String maNganhHoc)
        {
            NganhHoc nganhHoc = db.NganhHoc.Where(p => p.maNganhHoc == maNganhHoc).SingleOrDefault();
            return nganhHoc;
        }
     
        void LoadData()
        {
            var result = from c in db.NganhHoc
                         where c.idNganhHoc > 0
                         select new
                         {
                             maNganhHoc = c.maNganhHoc,
                             tenNganhHoc = c.tenNganhHoc,
                             soTinChi = c.soTinChi,
                             namBatDau = c.namBatDau  ,
                         };
            dGVNganhHoc.DataSource = result.ToList();
        }
        void AddData()
        {
            NganhHoc nganhHoc = new NganhHoc()
            {
                maNganhHoc = new string(tbTenNH.Text.Where(char.IsUpper).ToArray()),
                tenNganhHoc = tbTenNH.Text,
                namBatDau = dTPNam.Value.Date.Year,
            };
            if (db.NganhHoc.Any(p => p.maNganhHoc == nganhHoc.maNganhHoc))
            {

                MessageBox.Show("Mã ngành này đã bị trùng, vui lòng đổi tên ngành!");
            }
            else
            {
                db.NganhHoc.Add(nganhHoc);
                db.SaveChanges();
                MessageBox.Show("Thêm ngành học thành công!");
                ResetData();
            }
        }

        void EditData(String maNganhHoc)
        {
            string oldNH = SelectData(maNganhHoc).maNganhHoc;
            string newNH = new string(tbTenNH.Text.Where(char.IsUpper).ToArray());

            NganhHoc nganhHoc = db.NganhHoc.Find(SelectData(maNganhHoc).idNganhHoc);
            nganhHoc.tenNganhHoc = tbTenNH.Text;
            nganhHoc.maNganhHoc = newNH;
            nganhHoc.namBatDau = dTPNam.Value.Date.Year;
            if (db.NganhHoc.Any(p => p.maNganhHoc == nganhHoc.maNganhHoc) && oldNH != newNH)
                MessageBox.Show("Mã ngành này đã bị trùng, vui lòng đổi tên ngành!");
            else 
            {
                db.SaveChanges();                
                MessageBox.Show("Sửa thông tin ngành học thành công!");             
            } 
        }

        void DeleteData(String maNganhHoc)
        {
            if (db.Lop.Any(p => p.NganhHoc.maNganhHoc == maNganhHoc))
                MessageBox.Show("Ngành học " + maNganhHoc + " đã có lớp học, không thể xóa!");
            else if (db.PhanChiaMonHoc.Any(p => p.NganhHoc.maNganhHoc == maNganhHoc))
                MessageBox.Show("Ngành học " + maNganhHoc + " đã có môn học, không thể xóa!");
            else
            {
                db.NganhHoc.Remove(SelectData(maNganhHoc));
                db.SaveChanges();
                MessageBox.Show("Xóa Ngành Học thành công!");
                ResetData();
            }
        }

        void ResetData()
        {
            tbMaNH.Clear();
            tbTenNH.Clear();
            dTPNam.Value = DateTime.Now;
            tbSoTC.Clear();
        }

        Boolean CheckNotNull()
        {
            if (string.IsNullOrEmpty(tbTenNH.Text))
                return false;
            else
                return true;
        }

        #region events

        private void button5_Click(object sender, EventArgs e)
        {
            ChiaMonForm chiaMonForm = new ChiaMonForm();
            chiaMonForm.ShowDialog();
            LoadData();
        }


        private void dGVNganhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (CheckNotNull())
            {
                AddData();
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaNH.Text)&&CheckNotNull())
            {
                EditData(tbMaNH.Text.ToString());
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngành học và điền đầy đủ thông tin!");
            }            
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetData();
            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaNH.Text))
            {
                DeleteData(tbMaNH.Text.ToString());
                LoadData();
            }
            else
               MessageBox.Show("Vui lòng chọn ngành học");
        } 
        #endregion
    }
}
