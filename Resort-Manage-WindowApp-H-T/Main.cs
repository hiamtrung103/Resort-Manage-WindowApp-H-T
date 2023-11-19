using Bunifu.Framework.UI;
using System;
using System.Windows.Forms;
using Krypton.Toolkit;
using Resort_Manage_WindowApp_H_T.Frm;
using Resort_Manage_WindowApp_H_T.Frm_Log_Reg;
using Resort_Manage_WindowApp_H_T.Interface;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Resort_Manage_WindowApp_H_T
{
    public partial class Main : KryptonForm
    {
        public Main()
        {
            InitializeComponent();
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
            taotaikhoan UI = new taotaikhoan();
            UI.Show();
        }

        private void btnNhanVien_click(object sender, EventArgs e)
        {
            this.Hide();
            LoginNV UI = new LoginNV();
            UI.Show();
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

        private void Doimaulabel(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    label.ForeColor = Color.White;
                }
            }
        }

        private void Doimaulabel2(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    label.ForeColor = Color.Black;
                }
            }
        }
        private void KtraBatTat_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButton1.Checked)
            {
                panelMain.BackColor = Color.FromArgb(51, 51, 51);
                panel4.BackColor = Color.FromArgb(44, 62, 80);
                bunifuCards3.BackColor = Color.FromArgb(26, 26, 26);
                Doimaulabel(label1, label2, label4, label5, label6);
                pictureBox1.Image = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\2.gif");
            }
            else
            {
                panelMain.BackColor = System.Drawing.SystemColors.Control;
                panel4.BackColor = System.Drawing.Color.Gainsboro;
                bunifuCards3.BackColor = System.Drawing.Color.WhiteSmoke;
                Doimaulabel2(label1, label2, label4, label5, label6);
                pictureBox1.Image = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\1.gif");
            }
        }
    }
}