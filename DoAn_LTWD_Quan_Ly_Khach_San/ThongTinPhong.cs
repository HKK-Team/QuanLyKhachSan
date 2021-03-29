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
    public partial class ThongTinPhong : Form
    {
        string MySQLConnectionString = @"server=localhost;user id=root;password = 260601;persistsecurityinfo=True;database=ql_khach_san";
        MySqlConnection Connection;
        MySqlCommand MySqlcommand;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable table = new DataTable();
        private void ThongTinPhong_Load(object sender, EventArgs e)
        {
            Connection = new MySqlConnection(MySQLConnectionString);
            Connection.Open();
            showdata();
            loadMaPhong();
        }
        private void loadMaPhong()
        {
            cbMaPhong.Items.Clear();
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandType = CommandType.Text;
            MySqlcommand.CommandText = "select maphong from phong";
            MySqlcommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter = new MySqlDataAdapter(MySqlcommand);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbMaPhong.Items.Add(dr["maphong"].ToString());
            }
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
        public ThongTinPhong()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinKhachHang formkhachhang = new ThongTinKhachHang();
            formkhachhang.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToan thanhtoan = new ThanhToan();
            thanhtoan.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int ans;
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "select* from phong where maphong = '" + cbMaPhong.Text + "' or tinhtrang = '"+cbTinhTrang.Text+"'";
            adapter.SelectCommand = MySqlcommand;
            table.Clear();
            adapter.Fill(table);
            dgShowPhong.DataSource = table;
        }

        private void dgShowPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgShowPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ans;
            ans = dgShowPhong.CurrentRow.Index;
            cbMaPhong.Text = dgShowPhong.Rows[ans].Cells[0].Value.ToString();
            cbTinhTrang.Text = dgShowPhong.Rows[ans].Cells[3].Value.ToString();
        }
    }
}
