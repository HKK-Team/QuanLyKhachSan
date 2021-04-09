using System;
using System.Collections;
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
        MySqlDataReader dr;
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }
        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            Connection = new MySqlConnection(MySQLConnectionString);
            ShowDT();
            ShowDTNam();
            ShowKhachhang();
        }
        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();
  
        public void ShowDT()
        {
            MySqlcommand = new MySqlCommand("select month(ngaydi) as Thang,sum(sotiendathanhtoan) as Tong_DT_Thang from thongkegiaodich group by month(ngaydi) order by month(ngaydi);", Connection);
            MySqlcommand.CommandType = CommandType.Text;
            Connection.Open();
            dr = MySqlcommand.ExecuteReader();
            while (dr.Read())
            {
                a.Add(dr.GetString(0));
                b.Add(dr.GetInt32(1));
            }
            chartThang.Series[0].Points.DataBindXY(a, b);
            dr.Close();
            Connection.Close();
        }
        ArrayList d = new ArrayList();
        ArrayList c = new ArrayList();
        private void ShowDTNam()
        { 
            MySqlcommand = new MySqlCommand("select year(ngaydi) as Nam,sum(sotiendathanhtoan) as Tong_DT_Nam from thongkegiaodich  group by year(ngaydi) order by year(ngaydi);", Connection);
            MySqlcommand.CommandType = CommandType.Text;
            Connection.Open();
            dr = MySqlcommand.ExecuteReader();
            while (dr.Read())
            {
                d.Add(dr.GetString(0));
                c.Add(dr.GetInt32(1));
            }
            chartNamm.Series[0].Points.DataBindXY(d, c);
            dr.Close();
            Connection.Close();
        }
        ArrayList Producto = new ArrayList();
        ArrayList Cant = new ArrayList();
        private void ShowKhachhang()
        {
            MySqlcommand = new MySqlCommand("select month(ngaydi) as thang ,count(magd) from thongkegiaodich group by month(ngaydi) order by  month(ngaydi);", Connection);
            MySqlcommand.CommandType = CommandType.Text;
            Connection.Open();
            dr = MySqlcommand.ExecuteReader();
            while (dr.Read())
            {
                Producto.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1));
            }
            chartkhachhang.Series[0].Points.DataBindXY(Producto, Cant);
            dr.Close();
            Connection.Close();
        }
    }
}
