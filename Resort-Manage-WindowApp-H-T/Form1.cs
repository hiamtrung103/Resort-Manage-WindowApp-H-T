using Bunifu.Framework.UI;
using Krypton.Toolkit;
using Resort_Manage_WindowApp_H_T.Interface;
//using ComponentFactory.Krypton.Toolkit;

namespace Resort_Manage_WindowApp_H_T
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool passwordVisible = false;

        private void hiddenshow_Click(object sender, EventArgs e)
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

        private void btnDangNhap_click(object sender, EventArgs e)
        {
            if (txtUserName.Texts == "123" && txtPass.Texts == "123")
            {
                this.Hide();
                loadingUI loadingUI = new loadingUI();
                loadingUI.Show();
            }
            else if (string.IsNullOrEmpty(txtUserName.Texts) || string.IsNullOrEmpty(txtPass.Texts))
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin tài khoản hoặc mật khẩu để đăng nhập!!");
            }
            else
            {
                MessageBox.Show("Bạn điền sai tài khoản hoặc mật khẩu, vui lòng thử lại!!");
            }
        }
        private void checkBoxToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButton1.Checked)
            {
                panel1.BackColor = Color.FromArgb(51, 51, 51);
                panel4.BackColor = Color.FromArgb(44, 62, 80);
                bunifuCards3.BackColor = Color.FromArgb(26, 26, 26);
                label1.ForeColor = System.Drawing.Color.White;
                label2.ForeColor = System.Drawing.Color.White;
                label4.ForeColor = System.Drawing.Color.White;
                label5.ForeColor = System.Drawing.Color.White;
                label6.ForeColor = System.Drawing.Color.White;
                pictureBox1.Image = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\2.gif");
            }
            else
            {
                panel1.BackColor = System.Drawing.SystemColors.Control;
                panel4.BackColor = System.Drawing.Color.Gainsboro;
                bunifuCards3.BackColor = System.Drawing.Color.WhiteSmoke;
                label1.ForeColor = System.Drawing.Color.Black;
                label2.ForeColor = System.Drawing.Color.Black;
                label4.ForeColor = System.Drawing.Color.Black;
                label5.ForeColor = System.Drawing.Color.Black;
                label6.ForeColor = System.Drawing.Color.Black;
                pictureBox1.Image = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\1.gif");
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            taotaikhoan UI = new taotaikhoan();
            UI.Show();
        }
    }
}