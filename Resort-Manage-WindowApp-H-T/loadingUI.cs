using Krypton.Toolkit;
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
            }
            else
            {
                timer1.Stop();

                await Task.Delay(1000);

                Main_UI mainUI = new Main_UI();
                mainUI.Show();
                //Form1 form1 = new Form1();
                //form1.Show();

                this.Hide();
            }
        }
    }
}
