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

namespace Resort_Manage_WindowApp_H_T
{
    public partial class Main_UI : KryptonForm
    {
        public Main_UI()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(pictureBox9, pictureBox9.Width, 0);
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.BackColor = Color.WhiteSmoke;
                label.ForeColor = Color.LightBlue;
            }
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.BackColor = Color.WhiteSmoke;
                label.ForeColor = Color.Red;
            }
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.BackColor = SystemColors.Control;
                label.ForeColor = SystemColors.ControlText;
            }
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

