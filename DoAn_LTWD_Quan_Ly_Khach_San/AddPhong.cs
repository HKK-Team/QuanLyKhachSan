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
    public partial class AddPhong : Form
    {
        string MySQLConnectionString = @"server=localhost;user id=root;password = 260601;persistsecurityinfo=True;database=ql_khach_san";
        MySqlConnection Connection;
        MySqlCommand MySqlcommand;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable table = new DataTable();
        public AddPhong()
        {
            InitializeComponent();
        }
        void showdata()
        {
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "select* from Phong";
            adapter.SelectCommand = MySqlcommand;
            table.Clear();
            adapter.Fill(table);
            dgShowPhong.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "insert into phong values('" + txtMaPhong.Text + "', '" + txtSoGiuong.Text + "', '" + txtDonGia.Text + "','" + txtTinhTrang.Text + "')";
            MySqlcommand.ExecuteNonQuery();
            MessageBox.Show("Bạn đã thêm thành công 1 phòng vào cơ sở dữ liệu.", "Thông Báo!",MessageBoxButtons.OK);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinPhong ttp = new ThongTinPhong();
            ttp.Show();
        }

        private void AddPhong_Load(object sender, EventArgs e)
        {
            Connection = new MySqlConnection(MySQLConnectionString);
            Connection.Open();
            showdata();
        }
    }
}
