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

namespace Resort_Manage_WindowApp_H_T.Views
{
    public partial class NhanVien : KryptonForm
    {
        string connectionString = @"Data Source=Trunq;Initial Catalog=nguoidungresort;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public NhanVien()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM nguoidungresort", con);
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
                cmd = new SqlCommand("SELECT * FROM nguoidungresort", con);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginNV UI = new LoginNV();
            UI.Show();
        }

        private void btnThem_click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=Trunq;Initial Catalog=nguoidungresort;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string tkMoi = txtTenDangKy.Text;
                    string mkMoi = txtMatKhauMoi.Text;
                    string emailMoi = txtEmail.Text;
                    string soDienThoaiMoi = txtSoDienThoai.Text;
                    string quyenMoi = "user";

                    string truyVanKiemTra = "SELECT COUNT(*) FROM nguoidungresort WHERE TaiKhoan=@tkMoi OR Email=@emailMoi";
                    using (SqlCommand cmdKiemTra = new SqlCommand(truyVanKiemTra, conn))
                    {
                        cmdKiemTra.Parameters.AddWithValue("@tkMoi", tkMoi);
                        cmdKiemTra.Parameters.AddWithValue("@emailMoi", emailMoi);
                        int soLuongNguoiDung = (int)cmdKiemTra.ExecuteScalar();

                        if (soLuongNguoiDung > 0)
                        {
                            MessageBox.Show("Tên đăng nhập hoặc email đã tồn tại. Vui lòng chọn tên hoặc email khác.");
                            return;
                        }
                    }

                    string truyVanThemMoi = "INSERT INTO nguoidungresort (TaiKhoan, MatKhau, Email, Quyen, SoDienThoai, TruyCap) " +
                                           "VALUES (@tkMoi, @mkMoi, @emailMoi, @quyenMoi, @soDienThoaiMoi, @truyCapMoi)";
                    using (SqlCommand cmdThemMoi = new SqlCommand(truyVanThemMoi, conn))
                    {
                        cmdThemMoi.Parameters.AddWithValue("@tkMoi", tkMoi);
                        cmdThemMoi.Parameters.AddWithValue("@mkMoi", mkMoi);
                        cmdThemMoi.Parameters.AddWithValue("@emailMoi", emailMoi);
                        cmdThemMoi.Parameters.AddWithValue("@quyenMoi", quyenMoi);
                        cmdThemMoi.Parameters.AddWithValue("@soDienThoaiMoi", soDienThoaiMoi);
                        cmdThemMoi.ExecuteNonQuery();

                        MessageBox.Show("Đăng ký thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }

    }

}