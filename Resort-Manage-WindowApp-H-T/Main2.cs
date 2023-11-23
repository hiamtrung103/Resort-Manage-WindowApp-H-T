using Bunifu.Framework.UI;
using Krypton.Toolkit;
using Resort_Manage_WindowApp_H_T.Frm;
using Resort_Manage_WindowApp_H_T.Frm_Log_Reg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resort_Manage_WindowApp_H_T
{
    public partial class Main2 : KryptonForm
    {
        private bool isDarkMode = false;

        public Main2()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
                panel1.BackgroundImage = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\5166950.jpg"); //5153829

            }
            else
            {
                panelMain.BackColor = System.Drawing.SystemColors.Control;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                panel1.BackgroundImage = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\5153829.jpg");
            }
        }
        private void btnDangNhap_click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=Trunq;Initial Catalog=NguoiDung;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string tk = txtUserName.Texts;
                    string mk = txtPass.Texts;
                    string sql = "SELECT * FROM ngDung WHERE TaiKhoan=@tk AND MatKhau=@mk";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tk", tk);
                        cmd.Parameters.AddWithValue("@mk", mk);

                        using (SqlDataAdapter dta = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            dta.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                this.Hide();
                                loadingUI UI = new loadingUI();
                                UI.Show();
                                MessageBox.Show("Đăng nhập thành công");
                            }
                            else if (string.IsNullOrEmpty(txtUserName.Texts) || string.IsNullOrEmpty(txtPass.Texts))
                            {
                                MessageBox.Show("Bạn cần điền đủ thông tin đăng nhập để có thể tiếp tục", "Thiếu thông tin đăng nhập");
                            }
                            else
                            {
                                MessageBox.Show("Đăng nhập thất bại");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        private void btnDangKy_click(object sender, EventArgs e)
        {
            this.Hide();
            Main3 UI = new Main3();
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
            if (txtPass.PasswordChar == true)
            {
                txtPass.PasswordChar = false;
            }
            else
            {
                txtPass.PasswordChar = true;
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
    }
}