using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Resort_Manage_WindowApp_H_T.Frm_Log_Reg;
using Resort_Manage_WindowApp_H_T.Interface;

namespace Resort_Manage_WindowApp_H_T.Views
{
    public partial class NhanVien : KryptonForm
    {
        private Form frmConHientai;

        public NhanVien()
        {
            InitializeComponent();

        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
        }

        private void MofrmCon(Form frmCon)
        {
            if (frmConHientai != null)
            {
                frmConHientai.Close();
            }

            frmConHientai = frmCon;

            frmCon.TopLevel = false;
            frmCon.FormBorderStyle = FormBorderStyle.None;
            frmCon.Dock = DockStyle.Fill;

            panelMain.Controls.Add(frmCon);
            panelMain.Tag = frmCon;
            frmCon.BringToFront();
            frmCon.Show();
        }

        private void frmNhanVienOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmNhanVien());
        }


    }

}