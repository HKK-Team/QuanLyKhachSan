using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DoAn_LTWD_Quan_Ly_Khach_San
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            runQuery();
        }
        private void runQuery()
        {
            // kết nối với sever trong mysql
            string MySQLConnectionString = @"datasource = 127.0.0.1; port = 3306; username = root; password = 260601; database = ql_khach_san";
            // gọi hàm kết nối mysql và gán trực tiếp nó vào C#
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            try
            {
                databaseConnection.Open();
                string TK_query = txtTaiKhoan.Text;
                string MK_query = txtMatKhau.Text;
                string MySql = "select * from admin where taikhoan= '" + TK_query + "' and matkhau = '" + MK_query + "'";
                // tạo ra một vùng nhớ của hệ thống thực hiện yêu cầu liên kết với cơ sở dữ liệu
                MySqlCommand cmd = new MySqlCommand(MySql, databaseConnection);
                // gọi phương thức sử dụng câu lệnh select
                MySqlDataReader data = cmd.ExecuteReader();
                if(data.Read() == true) // đọc thông tin từ bàn phím nhập vào hệ thống và so sánh với dữ liệu trong mysql rồi trả về cho giao diện
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông báo!",MessageBoxButtons.OK);
                    this.Hide();
                    TrangChu TTKH = new TrangChu();
                    TTKH.Show();
                }
                else
                {
                    MessageBox.Show("Sai thông tin tai khoản hoặc mật khẩu! Xin vui lòng Đăng Nhập Lại.","Thông Báo!",MessageBoxButtons.OK);
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi kết nối!","Thông Báo!");
            }
        }


        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có thực sự muốn thoát chương trình hay không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (a == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
        private void txtTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            txtTaiKhoan.Clear();
            panel1.BackColor = Color.FromArgb(181, 255, 248);
            iconPictureBox3.ForeColor = Color.FromArgb(181, 255, 248);
        }

        private void txtMatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            txtMatKhau.Clear();
            panel3.BackColor = Color.FromArgb(181, 255, 248);
            iconPictureBox4.ForeColor = Color.FromArgb(181, 255, 248);
        }

  
        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }
    }
}
