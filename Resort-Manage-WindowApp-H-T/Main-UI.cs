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
using System.Xml.Linq;
using TheArtOfDev.HtmlRenderer.Adapters.Entities;

namespace Resort_Manage_WindowApp_H_T
{
    public partial class Main_UI : KryptonForm
    {
        private Form frmConHientai;
        public Main_UI()
        {
            InitializeComponent();
        }

        private void Main_UI_Load(object sender, EventArgs e)
        {
            MofrmCon(new trangchu());
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Main form1 = new Main();
                form1.Show();
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(pictureBox9, pictureBox9.Width, 0);
        }

        private void DoiMauLabel_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = Color.LightBlue;
            }
        }
        private void DoiMauLabel2_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = Color.Red;
            }
        }

        private void DoiMauLabel_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = toggleButton1.Checked ? Color.White : SystemColors.ControlText;
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

        private void ktraBatTat_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButton1.Checked)
            {
                panel1.BackColor = Color.FromArgb(51, 51, 51);
                bunifuCards1.BackColor = Color.FromArgb(51, 51, 51);
                Doimaulabel(label1, label3, label4, label5, label6, label7, label8, label9, label10);
            }
            else
            {
                panel1.BackColor = System.Drawing.SystemColors.Control;
                bunifuCards1.BackColor = System.Drawing.Color.White;
                Doimaulabel2(label1, label3, label4, label5, label6, label7, label8, label9, label10);
            }
        }

        private void MofrmCon(Form frmCon)
        {
            if (frmConHientai != null)
            {
                frmConHientai.FormClosed -= frmCon_Tat;
                frmConHientai.Close();
            }

            frmConHientai = frmCon;
            frmConHientai.FormClosed += frmCon_Tat;

            frmCon.TopLevel = false;
            //frmCon.FormBorderStyle = FormBorderStyle.None;
            //frmCon.Dock = DockStyle.Fill;

            panelMain.Controls.Add(frmCon);
            panelMain.Tag = frmCon;
            //frmCon.BringToFront();
            frmCon.Show();
        }

        private void frmCon_Tat(object sender, FormClosedEventArgs e)
        {
            Form closedForm = sender as Form;
            if (closedForm != null)
            {
                closedForm.Dispose();
            }
        }

        private void trangchuOpen(object sender, EventArgs e)
        {
            MofrmCon(new trangchu());
        }

        private void yeuthichOpen(object sender, EventArgs e)
        {
            MofrmCon(new yeuthich());
        }

        private void datphongOpen(object sender, EventArgs e)
        {
            MofrmCon(new datphong());
        }

        private void lichsuOpen(object sender, EventArgs e)
        {
            MofrmCon(new lichsu());
        }

        private void hotroOpen(object sender, EventArgs e)
        {
            MofrmCon(new hotro());
        }
    }
}

