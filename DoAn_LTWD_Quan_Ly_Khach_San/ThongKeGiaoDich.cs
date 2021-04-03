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
    public partial class ThongKeGiaoDich : Form
    {
        string MySQLConnectionString = @"server=localhost;user id=root;password = 260601;persistsecurityinfo=True;database=ql_khach_san";
        MySqlConnection Connection;
        MySqlCommand MySqlcommand;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable table = new DataTable();
        public ThongKeGiaoDich()
        {
            InitializeComponent();
        }
        private void loadMaKH()
        {
            cbMaKH.Items.Clear();
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandType = CommandType.Text;
            MySqlcommand.CommandText = "select makh from khachhang";
            MySqlcommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter = new MySqlDataAdapter(MySqlcommand);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbMaKH.Items.Add(dr["makh"].ToString());
            }
        }    
        private void loadPhong()
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
        private void ShowDaTa()
        {
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "select* from thongkegiaodich";
            adapter.SelectCommand = MySqlcommand;
            table.Clear();
            adapter.Fill(table);
            dgShowGD.DataSource = table;
        }

        private void ThongKeGiaoDich_Load(object sender, EventArgs e)
        {
            Connection = new MySqlConnection(MySQLConnectionString);
            Connection.Open();
            loadMaKH();
            loadPhong();
            ShowDaTa();
        }

        private void dgShowGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ans;
            ans = dgShowGD.CurrentRow.Index;
            cbMaKH.Text = dgShowGD.Rows[ans].Cells[1].Value.ToString();
            cbMaPhong.Text = dgShowGD.Rows[ans].Cells[2].Value.ToString();
            dtNgayDen.Text = dgShowGD.Rows[ans].Cells[3].Value.ToString();
            dtNgayDi.Text = dgShowGD.Rows[ans].Cells[4].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "select * from thongkegiaodich where maphong = '" + cbMaPhong.Text + "' or makh = '" + cbMaKH.Text + "'";
            adapter.SelectCommand = MySqlcommand;
            table.Clear();
            adapter.Fill(table);
            dgShowGD.DataSource = table;
        }

        private void thôngTinKháchHaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingRoom formkhachhang = new BookingRoom();
            formkhachhang.Show();
        }

        private void thôngTinPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinPhong Phong = new ThongTinPhong();
            Phong.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment thanhtoan = new Payment();
            thanhtoan.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có thực sự muốn thoát chương trình hay không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (a == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
