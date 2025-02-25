using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienHunre
{
    public partial class MenuSinhVien : Form
    {
        private Form currentFormChild;
        public string idSV;
        public MenuSinhVien(String idSinhVien)
        {

            InitializeComponent();
            idSV = idSinhVien;
            RoundPanel();
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
            panel4.Controls.Add(childForm);
            childForm.Show();
        }
        private void btTTCN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinSinhVienForm(idSV));
            label1.Text = btTTCN.Text;


        }

        private void btKetQua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KetQuaSinhVien(idSV));
            label1.Text=btKetQua.Text;
        }
        private void RoundPanel()
        {
            // Kích thước của các góc tròn
            int cornerRadius = 20;

            // Tạo đường dẫn hình chữ nhật có các góc tròn
            GraphicsPath roundRectPath = new GraphicsPath();
            roundRectPath.StartFigure();
            roundRectPath.AddArc(panel4.ClientRectangle.Left, panel4.ClientRectangle.Top, cornerRadius * 2, cornerRadius * 2, 180, 90); // Góc trên bên trái
            roundRectPath.AddLine(panel4.ClientRectangle.Left + cornerRadius, panel4.ClientRectangle.Top, panel4.ClientRectangle.Right - cornerRadius, panel4.ClientRectangle.Top); // Đoạn ngang ở trên
            roundRectPath.AddArc(panel4.ClientRectangle.Right - cornerRadius * 2, panel4.ClientRectangle.Top, cornerRadius * 2, cornerRadius * 2, 270, 90); // Góc trên bên phải
            roundRectPath.AddLine(panel4.ClientRectangle.Right, panel4.ClientRectangle.Top + cornerRadius, panel4.ClientRectangle.Right, panel4.ClientRectangle.Bottom - cornerRadius); // Đoạn dọc bên phải
            roundRectPath.AddArc(panel4.ClientRectangle.Right - cornerRadius * 2, panel4.ClientRectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90); // Góc dưới bên phải
            roundRectPath.AddLine(panel4.ClientRectangle.Right - cornerRadius, panel4.ClientRectangle.Bottom, panel4.ClientRectangle.Left + cornerRadius, panel4.ClientRectangle.Bottom); // Đoạn ngang ở dưới
            roundRectPath.AddArc(panel4.ClientRectangle.Left, panel4.ClientRectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90); // Góc dưới bên trái
            roundRectPath.CloseFigure();

            // Thiết lập vùng cắt cho panel
            panel4.Region = new Region(roundRectPath);
        }

        private void btTTCN_MouseHover(object sender, EventArgs e)
        {
            btTTCN.BackColor = Color.Khaki;
        }

        private void btTTCN_MouseLeave(object sender, EventArgs e)
        {
            btTTCN.BackColor = Color.CornflowerBlue;
        }

        private void btKetQua_MouseHover(object sender, EventArgs e)
        {
            btKetQua.BackColor = Color.Khaki;
        }

        private void btKetQua_MouseLeave(object sender, EventArgs e)
        {
            btKetQua.BackColor = Color.CornflowerBlue;
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
