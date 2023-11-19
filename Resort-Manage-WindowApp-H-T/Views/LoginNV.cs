using Resort_Manage_WindowApp_H_T.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Resort_Manage_WindowApp_H_T.Frm_Log_Reg
{
    public partial class LoginNV : KryptonForm
    {
        private int currentImageIndex = 0;
        private string[] imagePaths = {
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\manage.gif",
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\manage2.gif"
        };
        public LoginNV()
        {
            InitializeComponent();
            SetupImageTimer();
        }

        private void SetupImageTimer()
        {
            System.Windows.Forms.Timer imageTimer = new System.Windows.Forms.Timer();
            imageTimer.Interval = 3000;
            imageTimer.Tick += ImageTimer_Tick;
            imageTimer.Start();
        }

        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (currentImageIndex < imagePaths.Length - 1)
                {
                    currentImageIndex++;
                }
                else
                {
                    currentImageIndex = 0;
                }

                pictureBox1.ImageLocation = imagePaths[currentImageIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pictureBox1.ImageLocation = imagePaths[currentImageIndex];
        }

        private void btnDangNhap_click(object sender, EventArgs e)
        {
            if (txtUserName.Texts == "1" && txtPass.Texts == "1")
            {
                this.Hide();
                NhanVien UI = new NhanVien();
                UI.Show();
            }
            else if (string.IsNullOrEmpty(txtUserName.Texts) || string.IsNullOrEmpty(txtPass.Texts))
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin tài khoản hoặc mật khẩu để đăng nhập!!", "Chưa đủ thông tin!");
            }
            else
            {
                MessageBox.Show("Bạn điền sai tài khoản hoặc mật khẩu, vui lòng thử lại!!", "Sai tài khoản hoặc mật khẩu!");
            }

        }

    }
}
