using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienHunre
{
    public partial class MenuGiangVien: Form
    {
        private Form currentFormChild;
        public string idGV;
        public static bool dangxuat = false;
        public MenuGiangVien(String idGiangVien)
        {
            InitializeComponent();
            idGV = idGiangVien;

            AssignButtonTag(btKetQuaHocPhan, new KetQuaHocPhanForm(idGV));

        }


        bool sidebarExpand = false;

        private void AssignButtonTag(Button button, Form form)
        {
            button.Tag = form;
            button.Click += btChildForm_Click;
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
                    childForm = (Form)ctor.Invoke(new object[] { idGV });
                }
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(childForm);
            childForm.Show();
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
                pnKetQuaHocPhan.Width = sidebar.Width;
                pnLopHoc.Width = sidebar.Width;
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
                if (logoHunre.Location.X < 73)
                {
                    logoHunre.Location = new Point(logoHunre.Location.X + 8, logoHunre.Location.Y);
                    logoHunre.Width += 4;
                    logoHunre.Height += 4;
                }
                //phóng to sidebar
                sidebar.Width += 16;
                pnKetQuaHocPhan.Width = sidebar.Width;
                pnLopHoc.Width = sidebar.Width;
                pnTaiKhoan.Width = sidebar.Width;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }


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

        private void MenuGiangVien_Resize(object sender, EventArgs e)
        {

        }

        private void iconMenu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }
    }
}
