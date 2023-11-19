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
            if (txtMatKhauReg.PasswordChar == true || txtPass2.PasswordChar == true)
            {
                txtMatKhauReg.PasswordChar = false;
                txtPass2.PasswordChar = false;
            }
            else
            {
                txtMatKhauReg.PasswordChar = true;
                txtPass2.PasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Hide();
            Main UI = new Main();
            UI.Show();
        }

        private void btnDangKy_click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=Trunq;Initial Catalog=NguoiDung;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string tkMoi = txtTenDangNhapReg.Text;
                    string mkMoi = txtMatKhauReg.Text;

                    string sqlCheck = "SELECT COUNT(*) FROM ngDung WHERE TaiKhoan = @tkMoi";

                    using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@tkMoi", tkMoi);

                        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                            return;
                        }
                    }

                    string sqlInsert = "INSERT INTO ngDung (TaiKhoan, MatKhau) VALUES (@tkMoi, @mkMoi)";

                    using (SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@tkMoi", tkMoi);
                        cmdInsert.Parameters.AddWithValue("@mkMoi", mkMoi);

                        int soDongAnhHuong = cmdInsert.ExecuteNonQuery();

                        if (soDongAnhHuong > 0)
                        {
                            MessageBox.Show("Đăng ký thành công");
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại");
                        }
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
