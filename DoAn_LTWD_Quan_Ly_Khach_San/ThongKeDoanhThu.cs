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
    public partial class ThongKeDoanhThu : Form
    {
        string MySQLConnectionString = @"server=localhost;user id=root;password = 260601;persistsecurityinfo=True;database=ql_khach_san";
        MySqlConnection Connection; 
        MySqlCommand MySqlcommand; 
        MySqlDataAdapter adapter = new MySqlDataAdapter();  
        DataTable table = new DataTable(); 
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }
        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            Connection = new MySqlConnection(MySQLConnectionString);
            ShowDT();
            ShowDTNam();
        }
        public void ShowDT()
        {
            Connection.Open();
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandType = CommandType.Text;
            MySqlcommand.CommandText = "select month(ngaydi) as 'Thang',sum(sotiendathanhtoan) as 'Tong_DT_Thang' from thongkegiaodich group by month(ngaydi) order by month(ngaydi)";
            MySqlcommand.ExecuteNonQuery();
            adapter.SelectCommand = MySqlcommand;
            adapter.Fill(table);
            chartNamm.DataSource = table;
            chartNamm.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chartNamm.ChartAreas["ChartArea1"].AxisX.Title = "Doanh Thu (VNĐ)";

            chartNamm.Series["Series1"].XValueMember = "Thang";
            chartNamm.Series["Series1"].YValueMembers = "Tong_DT_Thang";
            Connection.Close();
        }
        public void ShowDTNam()
        {
            Connection.Open();
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandType = CommandType.Text;
            MySqlcommand.CommandText = "select year(ngaydi) as 'Nam',sum(sotiendathanhtoan) as 'Tong_DT_Nam' from thongkegiaodich  group by year(ngaydi) order by year(ngaydi)";
            MySqlcommand.ExecuteNonQuery();
            adapter.SelectCommand = MySqlcommand;
            adapter.Fill(table);
            chartThang.DataSource = table;
            chartThang.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
            chartThang.ChartAreas["ChartArea1"].AxisX.Title = "Doanh Thu (VNĐ)";

            chartThang.Series["Series1"].XValueMember = "Nam";
            chartThang.Series["Series1"].YValueMembers = "Tong_DT_Nam";
            Connection.Close();
        }

    }
}
