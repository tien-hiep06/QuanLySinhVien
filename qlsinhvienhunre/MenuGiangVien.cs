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

            AssignButtonTag(btLopHocPhan, new KetQuaHocPhanForm(idGV));
        }

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
    }
}
