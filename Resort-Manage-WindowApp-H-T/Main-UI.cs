using Bunifu.Framework.UI;
using Krypton.Toolkit;
using Resort_Manage_WindowApp_H_T.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters.Entities;

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

        private void checkBoxToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButton1.Checked)
            {
                panel1.BackColor = Color.FromArgb(24, 25, 26); ;
                //panel5.BackColor = System.Drawing.Color.DarkGray; //24, 25, 26
                bunifuCards1.BackColor = Color.FromArgb(24, 25, 26);
                label1.ForeColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;
                label4.ForeColor = System.Drawing.Color.White;
                label5.ForeColor = System.Drawing.Color.White;
                label6.ForeColor = System.Drawing.Color.White;
                label7.ForeColor = System.Drawing.Color.White;
                label8.ForeColor = System.Drawing.Color.White;
                label9.ForeColor = System.Drawing.Color.White;
                label10.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                panel1.BackColor = System.Drawing.SystemColors.Control;
                //panel5.BackColor = System.Drawing.SystemColors.Control;
                bunifuCards1.BackColor = System.Drawing.Color.White;
                label1.ForeColor = System.Drawing.Color.Black;
                label3.ForeColor = System.Drawing.Color.Black;
                label4.ForeColor = System.Drawing.Color.Black;
                label5.ForeColor = System.Drawing.Color.Black;
                label6.ForeColor = System.Drawing.Color.Black;
                label7.ForeColor = System.Drawing.Color.Black;
                label8.ForeColor = System.Drawing.Color.Black;
                label9.ForeColor = System.Drawing.Color.Black;
                label10.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            trangchu UI = new trangchu();
            UI.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            yeuthich UI = new yeuthich();
            UI.Show();
            this.Hide();
        }
    }
}

