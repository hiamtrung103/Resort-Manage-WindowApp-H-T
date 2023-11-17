using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resort_Manage_WindowApp_H_T.Interface
{
    public partial class trangchu : Main_UI
    {
        private int currentImageIndex = 0;
        private string[] imagePaths = {
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort-danang.jpg",
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort-danang2.jpg",
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort-khanhhoa.jpg",
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort-langco.jpg",
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort-anamadara.jpg",
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort-binhthuan.jpg",
        };

        public trangchu()
        {
            InitializeComponent();
            SetupImageTimer();
        }

        private void SetupImageTimer()
        {
            System.Windows.Forms.Timer imageTimer = new System.Windows.Forms.Timer();
            imageTimer.Interval = 3000; // 3 seconds
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

                pictureBox22.ImageLocation = imagePaths[currentImageIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pictureBox22.ImageLocation = imagePaths[currentImageIndex];
        }
    }
}
