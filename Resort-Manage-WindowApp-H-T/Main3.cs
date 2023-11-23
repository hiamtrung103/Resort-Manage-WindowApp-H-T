using Resort_Manage_WindowApp_H_T.Frm;
using Resort_Manage_WindowApp_H_T.Frm_Log_Reg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resort_Manage_WindowApp_H_T
{
    public partial class Main3 : Form
    {
        private bool isDarkMode = false;

        public Main3()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(pictureBox4, pictureBox4.Width, 0);
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                panelMain.BackColor = Color.FromArgb(51, 51, 51);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                panel1.BackgroundImage = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\sign-up2.jpg");

            }
            else
            {
                panelMain.BackColor = System.Drawing.SystemColors.Control;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                panel1.BackgroundImage = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\sign-up1.jpg");
            }
        }
        private void btnDangNhap_click(object sender, EventArgs e)
        {
            this.Hide();
            Main2 UI = new Main2();
            UI.Show();
        }

        private void btnNhanVien_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đây là phần đăng nhập dành riêng cho Administrator/Staff bạn có chắc chắn muốn chuyển ko?", "Chuyển sang Administrator/Staff đăng nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginNV UI = new LoginNV();
                UI.Show();
            }
        }

        private void Hien_An_MK_Click(object sender, EventArgs e)
        {
            if (txtTenDangKy.PasswordChar == true)
            {
                txtTenDangKy.PasswordChar = false;
            }
            else
            {
                txtTenDangKy.PasswordChar = true;
            }
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thoát chương trình", "Thông báo");
                Application.Exit();
            }
        }

        private void QuayLaiChuongTrinh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại chương trình cũ không?", "Quay lại chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }

        private void btnDangKy_click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=Trunq;Initial Catalog=NguoiDung;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string tkMoi = txtTenDangKy.Texts;
                    string mkMoi = txtMatKhauMoi.Texts;

                    string truyVanKiemTra = "SELECT COUNT(*) FROM ngDung WHERE TaiKhoan=@tkMoi";
                    using (SqlCommand cmdKiemTra = new SqlCommand(truyVanKiemTra, conn))
                    {
                        cmdKiemTra.Parameters.AddWithValue("@tkMoi", tkMoi);
                        int soLuongNguoiDung = (int)cmdKiemTra.ExecuteScalar();

                        if (soLuongNguoiDung > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.");
                            return;
                        }
                    }

                    string truyVanThemMoi = "INSERT INTO ngDung (TaiKhoan, MatKhau) VALUES (@tkMoi, @mkMoi)";
                    using (SqlCommand cmdThemMoi = new SqlCommand(truyVanThemMoi, conn))
                    {
                        cmdThemMoi.Parameters.AddWithValue("@tkMoi", tkMoi);
                        cmdThemMoi.Parameters.AddWithValue("@mkMoi", mkMoi);
                        cmdThemMoi.ExecuteNonQuery();

                        MessageBox.Show("Đăng ký thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }
    }
}
