using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_LTWD_Quan_Ly_Khach_San
{
    public partial class TrangChu_2 : Form
    {
        string MySQLConnectionString = @"server=localhost;user id=root;password = 260601;persistsecurityinfo=True;database=ql_khach_san";
        MySqlConnection Connection;
        MySqlCommand MySqlcommand;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable table = new DataTable();
        MySqlDataReader Read_Data;
        string Mysql;

        public TrangChu_2()
        {
            InitializeComponent();          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        string Mysql;
        MySqlDataReader Read_Data; // khởi tạo 1 biến để đọc giá trị
        private void TrangChu_2_Load(object sender, EventArgs e)
        {
            Connection = new MySqlConnection(MySQLConnectionString);
            showdata();
            Showlb_Phong();
            ShowSoPhongDD();
            ShowBill();

        }
        public void Showlb_Phong()
        {
            Connection.Open();
            Mysql = "select count(MAPHONG) as soluongphong from phong where TINHTRANG = 'Còn Trống'";
            MySqlCommand mySqlCommand = new MySqlCommand(Mysql, Connection);
            Read_Data = mySqlCommand.ExecuteReader();
            while (Read_Data.Read())
            {
                lbl_Phong.Text = "   Còn " + Read_Data[0].ToString() + " phòng";
            }
            Read_Data.Close();
            Connection.Close();
        }
        public void ShowSoPhongDD()
        {
            Connection.Open();
            showdata();
        }
        void showdata()
        {
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "select* from Phong " + "where Tinhtrang = N'Còn Trống'";
            adapter.SelectCommand = MySqlcommand;
            table.Clear();
            adapter.Fill(table);
            dgTC.DataSource = table;
        }
        void showKhachHang()
        {
            Mysql = "select count(MaKh) from khachhang ";
            MySqlCommand mySqlCommand = new MySqlCommand(Mysql, Connection);
            Read_Data = mySqlCommand.ExecuteReader();
            while (Read_Data.Read())
            {
                lbl_Khachhang.Text =  Read_Data[0].ToString() + " khách hàng";
            }
            Read_Data.Close();
        }
        




    }
}
