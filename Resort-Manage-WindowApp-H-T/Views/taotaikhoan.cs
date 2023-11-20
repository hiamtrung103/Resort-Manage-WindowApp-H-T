using Krypton.Toolkit;
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

namespace Resort_Manage_WindowApp_H_T.Frm
{
    public partial class taotaikhoan : KryptonForm
    {
        public taotaikhoan()
        {
            InitializeComponent();
        }

        private void AnHienMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.PasswordChar == true || txtPass2.PasswordChar == true)
            {
                txtMatKhauMoi.PasswordChar = false;
                txtPass2.PasswordChar = false;
            }
            else
            {
                txtMatKhauMoi.PasswordChar = true;
                txtPass2.PasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Hide();
            Main UI = new Main();
            UI.Show();
        }

        // Trong form đăng ký (taotaikhoan)
        private void btnDangKy_click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=Trunq;Initial Catalog=NguoiDung;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string tkMoi = txtTenDangKy.Texts; // Thay thế bằng tên thực tế của textbox để nhập tên đăng nhập
                    string mkMoi = txtMatKhauMoi.Texts; // Thay thế bằng tên thực tế của textbox để nhập mật khẩu

                    // Kiểm tra xem tên đăng nhập đã tồn tại trong cơ sở dữ liệu chưa
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

                    // Thêm người dùng mới vào cơ sở dữ liệu
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

        private void taotaikhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
