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

namespace Resort_Manage_WindowApp_H_T.Interface
{
    public partial class taotaikhoan : KryptonForm
    {
        public taotaikhoan()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == true || txtPass2.PasswordChar == true)
            {
                txtPass.PasswordChar = false;
                txtPass2.PasswordChar = false;
            }
            else
            {
                txtPass.PasswordChar = true;
                txtPass2.PasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 UI = new Form1();
            UI.Show();
        }
    }
}
