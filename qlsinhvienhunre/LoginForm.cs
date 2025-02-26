using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace QLSinhVienHunre
{
    public partial class LoginForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public LoginForm()
        {
            InitializeComponent();
            RoundPanel(panel2);
        }
        #region methods
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
        void CheckAcc()
        {
            if (tbPassWord == null || tbUserName == null)
            {
                MessageBox.Show("Vui lòng điền điền đẩy đủ thông tin");
                tbPassWord.Clear();
            }else if (db.NguoiDung.Where(tk => tk.SinhVien.maSinhVien == tbUserName.Text && tk.matKhau == tbPassWord.Text).SingleOrDefault() != null)
            {
                MessageBox.Show("Đăng nhập thành công");
                // Nếu thông tin đăng nhập chính xác, đóng form đăng nhập và mở form menu chính
                this.Hide();
                MenuSinhVien menuSV = new MenuSinhVien(tbUserName.Text);
                menuSV.ShowDialog();
                this.Close();
            }
            else if (db.NguoiDung.Where(tk => tk.GiangVien.maGiangVien == tbUserName.Text && tk.matKhau == tbPassWord.Text).SingleOrDefault() != null)
            {
                MessageBox.Show("Đăng nhập thành công");
                // Nếu thông tin đăng nhập chính xác, đóng form đăng nhập và mở form menu chính
                this.Hide();
                KetQuaHocPhanForm menuGV = new KetQuaHocPhanForm(tbUserName.Text);
                menuGV.ShowDialog();
                this.Close();
            }
            else if (db.NguoiDung.Where(tk => tk.matKhau == tbPassWord.Text && tk.chucVu == tbUserName.Text).SingleOrDefault() != null && tbUserName.Text == "ADMIN")
            {
                MessageBox.Show("Đăng nhập thành công");
                // Nếu thông tin đăng nhập chính xác, đóng form đăng nhập và mở form menu chính
                this.Hide();
                MenuADMIN menuADMIN = new MenuADMIN();
                menuADMIN.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                tbPassWord.Clear();
            }
        }

        #endregion

        #region event
        private void dangnhap_button_Click(object sender, EventArgs e)
        {
            CheckAcc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbPassWord.UseSystemPasswordChar = !tbPassWord.UseSystemPasswordChar;
        }


        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CheckAcc();
            }
        }


        private void btChangeStyle_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));// Gạch chân chữ
                btn.ForeColor = Color.DarkOrange; // Đổi màu khi di chuyển chuột vào
            }
        }

        private void btChangeStyle_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));// Gạch chân chữ
                btn.ForeColor = Color.Wheat; // Đổi màu khi di chuyển chuột vào
            }
        }

        private void btChangeStyle_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));// Gạch chân chữ
                btn.ForeColor = Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Hủy sự kiện đóng form
            }
        }
        #endregion
    }
}
