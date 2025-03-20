using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienHunre
{
    public partial class MenuSinhVien : Form
    {
        private Form currentFormChild;
        public string idSV;
        public static bool dangxuat = false;

        public MenuSinhVien(String idSinhVien)
        {   
            InitializeComponent();
            idSV = idSinhVien;
            RoundPanel(pnMain);
            RoundPanel(pnDangXuat);
            AssignButtonTag(btTTCN, new ThongTinSinhVienForm(idSV));
        }
        #region methods
        
        bool sidebarExpand = false;

        private void AssignButtonTag(Button button, Form form)
        {
            button.Tag = form;
            button.Click += btChildForm_Click;
        }
                        
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
                pnMain.Controls.Remove(currentFormChild);
                currentFormChild.Close();
            }
            if (childForm.IsDisposed)
            {
                Type formType = childForm.GetType();
                ConstructorInfo ctor = formType.GetConstructor(new Type[] { typeof(string) });

                if (ctor != null)
                {
                    childForm = (Form)ctor.Invoke(new object[] { idSV });
                }
                else
                {
                    childForm = (Form)Activator.CreateInstance(formType);
                }
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            childForm.Dock = DockStyle.Fill;

            pnMain.Controls.Add(childForm);
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
                pnTTCN.Width = sidebar.Width;
                pnkqht.Width = sidebar.Width;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                //phong to logo
                if (logoHunre.Location.X < 73)
                {
                    logoHunre.Location = new Point(logoHunre.Location.X + 8, logoHunre.Location.Y);
                    logoHunre.Width += 4;
                    logoHunre.Height += 4;
                }
                //phóng to sidebar
                sidebar.Width += 16;
                pnTTCN.Width = sidebar.Width;
                pnkqht.Width = sidebar.Width;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }
        #endregion

        #region events
        private void btChildForm_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                Form childForm = btn.Tag as Form;
                if (childForm != null)
                {
                    OpenChildForm(childForm);
                }
            }
        }

        private void btKetQua_Click(object sender, EventArgs e)
        {
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dangxuat = true;
                Application.Restart();
            }
        }
        private void MenuSinhVien_Resize(object sender, EventArgs e)
        {
            RoundPanel(pnMain);
        }

        private void iconMenu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }       
        #endregion
    }
}
