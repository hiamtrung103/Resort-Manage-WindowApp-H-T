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

namespace Resort_Manage_WindowApp_H_T.Views
{
    public partial class NhanVien : KryptonForm
    {
        string connectionString = @"Data Source=TRUNQ;Initial Catalog=NhanVien;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public NhanVien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM nhanvien", con);
                adt = new SqlDataAdapter(cmd);
                dt.Clear();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM nhanvien", con);
                adt = new SqlDataAdapter(cmd);
                dt.Clear();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}