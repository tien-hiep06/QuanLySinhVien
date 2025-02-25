using quanlisinhvienHUNRE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienHunre
{
    public partial class MenuADMIN : Form
    {
        private Form currentFormChild;

        public MenuADMIN()
        {
            InitializeComponent();
            RoundPanel(panel3);
            RoundPanel(pnDangXuat);
        }

        #region methods

        Button btnCurrent;
        bool sidebarExpand = false;
        private void RoundPanel(Panel panel)
        {
            // Kích thước của các góc tròn
            int cornerRadius = 20;
            // Tạo đường dẫn hình chữ nhật có các góc tròn
            GraphicsPath roundRectPath = new GraphicsPath();
            roundRectPath.StartFigure();
            roundRectPath.AddArc(panel.ClientRectangle.Left, panel.ClientRectangle.Top, cornerRadius * 2, cornerRadius * 2, 180, 90); // Góc trên bên trái
            roundRectPath.AddLine(panel.ClientRectangle.Left + cornerRadius, panel.ClientRectangle.Top, panel.ClientRectangle.Right - cornerRadius, panel.ClientRectangle.Top); // Đoạn ngang ở trên
            roundRectPath.AddArc(panel.ClientRectangle.Right - cornerRadius * 2, panel.ClientRectangle.Top, cornerRadius * 2, cornerRadius * 2, 270, 90); // Góc trên bên phải
            roundRectPath.AddLine(panel.ClientRectangle.Right, panel.ClientRectangle.Top + cornerRadius, panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - cornerRadius); // Đoạn dọc bên phải
            roundRectPath.AddArc(panel.ClientRectangle.Right - cornerRadius * 2, panel.ClientRectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90); // Góc dưới bên phải
            roundRectPath.AddLine(panel.ClientRectangle.Right - cornerRadius, panel.ClientRectangle.Bottom, panel.ClientRectangle.Left + cornerRadius, panel.ClientRectangle.Bottom); // Đoạn ngang ở dưới
            roundRectPath.AddArc(panel.ClientRectangle.Left, panel.ClientRectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90); // Góc dưới bên trái
            roundRectPath.CloseFigure();
            // Thiết lập vùng cắt cho panel
            panel.Region = new Region(roundRectPath);
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            childForm.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy sự kiện đóng form
            }
        }
        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //thu nho logo
                if (logoHunre.Location.X > 9)
                {
                    logoHunre.Location = new Point(logoHunre.Location.X - 8, logoHunre.Location.Y);
                    logoHunre.Width -= 4;
                    logoHunre.Height -= 4;
                }
                //thu nho sidebar
                sidebar.Width -= 16;
                pnNganhHoc.Width = sidebar.Width;
                pnLopHocPhan.Width = sidebar.Width;
                pnMonHoc.Width = sidebar.Width;
                pnLop.Width = sidebar.Width;
                pnGiangVien.Width = sidebar.Width;
                pnSinhVien.Width = sidebar.Width;
                pnTaiKhoan.Width = sidebar.Width;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else 
            {
                //phong to logo
                if (logoHunre.Location.X < 73 )
                {
                    logoHunre.Location = new Point(logoHunre.Location.X + 8, logoHunre.Location.Y);
                    logoHunre.Width += 4;
                    logoHunre.Height += 4;
                }
                //phóng to sidebar
                sidebar.Width += 16;
                pnNganhHoc.Width = sidebar.Width;
                pnLopHocPhan.Width = sidebar.Width;
                pnMonHoc.Width = sidebar.Width;
                pnLop.Width = sidebar.Width;
                pnGiangVien.Width = sidebar.Width;
                pnSinhVien.Width = sidebar.Width;
                pnTaiKhoan.Width = sidebar.Width;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        //private void ActiveButton(object btnSender)
        //{
        //    if(btnSender != null)
        //    {
        //        DisableButton();
        //        if(btnCurrent != (Button)btnSender)                
        //            btnCurrent.BackColor = Color.FromArgb(199,211,244);
        //    }
        //}
        //private void DisableButton()
        //{
        //    foreach (Control previousButton in sidebar.Controls)
        //    {
        //        if(previousButton.GetType() == typeof(Button))
        //            btnCurrent.BackColor = Color.FromArgb(40, 58, 116);
        //    }
        //}
        #endregion

        #region events
        private void btGiangVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GiangVienForm());
/*            ActiveButton(sender);*/
        }

        private void buttonLopHocPhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopHocPhanForm());
/*            ActiveButton(sender);*/
        }

        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TaiKhoanNguoiDung());
/*            ActiveButton(sender);*/
        }

        private void btSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVienForm());
/*            ActiveButton(sender);*/
        }

        private void btMonHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MonHocForm());
/*            ActiveButton(sender);*/
        }

        private void btNganhHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NganhHocForm());
/*            ActiveButton(sender);*/
        }

        private void btLopHocPhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopHocPhanForm());
/*            ActiveButton(sender);*/
        }

        private void btLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopForm());
/*            ActiveButton(sender);*/
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm lg = new LoginForm();
                lg.ShowDialog();
                this.Close();
            }
        }

        private void MenuADMIN_Resize(object sender, EventArgs e)
        {
            RoundPanel(panel3);
        }

        private void iconMenu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        #endregion
    }
}
