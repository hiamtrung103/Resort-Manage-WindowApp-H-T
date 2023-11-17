using Krypton.Toolkit;
using Resort_Manage_WindowApp_H_T.Interface;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resort_Manage_WindowApp_H_T
{
    public partial class loadingUI : KryptonForm
    {
        private int progressValue = 0;

        public loadingUI()
        {
            InitializeComponent();
            SetupProgressBar();
        }

        private void SetupProgressBar()
        {
            progressBar1.Maximum = 100;

            progressBar1.Minimum = 0;

            timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (progressValue < progressBar1.Maximum)
            {
                progressValue++;
                progressBar1.Value = progressValue;
                label3.Text = $"{progressValue}%";

                if (progressValue == 50)
                {
                    label4.Text = "Mọi ưu tiên trải nghiệm của \nkhách hàng đặt lên mọi hàng đầu!!";
                    pictureBox3.Image = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\dazzle-cloud-software.gif");
                }
            }
            else
            {
                timer1.Stop();

                await Task.Delay(1000);

                trangchu UI = new trangchu();
                UI.Show();

                this.Hide();
            }
        }
    }
}
