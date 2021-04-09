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
    public partial class BookingRoom : Form
    {
        // khai báo một chuỗi kết nối = MySQLConnectionString
        string MySQLConnectionString = @"server=localhost;user id=root;password = 260601;persistsecurityinfo=True;database=ql_khach_san";
        MySqlConnection Connection;
        MySqlCommand MySqlcommand;
        // Khởi tạo đôi tượng có tên là adapter
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        // khởi tạo đối tượng có tên là table dùng để lưu các giá trị của bảng vào database
        DataTable table = new DataTable();
        MySqlDataReader Read_Data;
        public BookingRoom()
        {
            InitializeComponent();
        }
        public void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            // khỏi tạo giá trị có để kết nối dữ liệu với mysql
            Connection = new MySqlConnection(MySQLConnectionString);
            Connection.Open();
            ShowData();
            ThanhToanLoad();
            showMaKh();
        }
        public void ThanhToanLoad()
        {
            cbMaPhong.Items.Clear();
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandType = CommandType.Text;
            MySqlcommand.CommandText = "select maphong from phong where TinhTrang = 'Còn Trống'";
            MySqlcommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter = new MySqlDataAdapter(MySqlcommand);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbMaPhong.Items.Add(dr["maphong"].ToString());
            }
        }

        void ShowData()
        { 
           
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "select* from khachhang";
            adapter.SelectCommand = MySqlcommand;
            table.Clear();
            adapter.Fill(table);
            dgShowThongTin.DataSource = table;
        }

 
        private void btnThem_Click(object sender, EventArgs e)
        {
            Connection.Open();
            // khởi tạo một giá trị mới để gán dữ liệu
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "insert into khachhang(`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`)  values('" + txtHoTen.Text + "', '" + txtCMND.Text + "','" + dateNgayDen.Text + "', '" + cbMaPhong.Text + "','" + cbTinhTrangThanhToan.Text + "') ";                                      
            // nếu câu lệnh truy vấn sai thì sẽ báo lỗi
            MySqlcommand.ExecuteNonQuery();
            ShowData(); 
            load();
            Connection.Close();
            


        }
        private void load()
        {
            
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "update phong set tinhtrang = 'Đã Có Khách' where maphong = '" + cbMaPhong.Text + "'";
            adapter.SelectCommand = MySqlcommand;
            adapter.Fill(table);
            ThanhToanLoad();
            showMaKh();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Connection.Open();
            MessageBox.Show("Bạn có muốn lưu thông tin khách hàng vào cơ sở dữ liệu không?", "Thông Báo!", MessageBoxButtons.YesNo);
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "update phong set tinhtrang = 'Đã Có Khách' where maphong = '" + cbMaPhong.Text + "'";
            adapter.SelectCommand = MySqlcommand;
            adapter.Fill(table);
            Connection.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connection.Open();
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "delete from thongkegiaodich where makh = '" + lbl_MaKh.Text + "'";
            MySqlcommand.ExecuteNonQuery();
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "delete from khachhang where makh = '" + lbl_MaKh.Text + "'";
            MySqlcommand.ExecuteNonQuery();
            ShowData();
            Connection.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connection.Open();
            MySqlcommand = Connection.CreateCommand();
            MySqlcommand.CommandText = "update khachhang set hoten = '" + txtHoTen.Text + "',socmnd = '" + txtCMND.Text + "', ngayden =  '" + dateNgayDen.Text + "', maphong = '" + cbMaPhong.Text + "',tinhtrangtt = '" +cbTinhTrangThanhToan.Text + "' where makh = '" + lbl_MaKh.Text + "'";
            MySqlcommand.ExecuteNonQuery();
            ShowData();
            Connection.Close();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgShowThongTin_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // mạc định cho textbox MaKh chỉ được đọc chứ không được xóa hoặc sửa vì nó là khóa chính nên không có thể đụng vô đc
            //txtMaKH.ReadOnly = true;
            int ans;
            // trỏ đến thành phần giá trị của thuộc tính trong datagridview để hiển thị lên phần điền thông tin khách hàng
            ans = dgShowThongTin.CurrentRow.Index;
            lbl_MaKh.Text = dgShowThongTin.Rows[ans].Cells[0].Value.ToString();
            txtHoTen.Text = dgShowThongTin.Rows[ans].Cells[1].Value.ToString();
            txtCMND.Text = dgShowThongTin.Rows[ans].Cells[2].Value.ToString();
            dateNgayDen.Text = dgShowThongTin.Rows[ans].Cells[3].Value.ToString();
            cbMaPhong.Text = dgShowThongTin.Rows[ans].Cells[4].Value.ToString();
            cbTinhTrangThanhToan.Text = dgShowThongTin.Rows[ans].Cells[5].Value.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Connection.Open();
            ThongTinKhachHang_Load(sender,e);
            txtCMND.Text = "";
            txtHoTen.Text = "";
            cbMaPhong.Text = "";
            cbTinhTrangThanhToan.Text = "Chưa Thanh Toán";
            Connection.Close();
        }
        private void showMaKh()
        {
            
            string Mysql = "SELECT max(makh)+1 FROM khachhang ;";
            MySqlCommand mySqlCommand = new MySqlCommand(Mysql, Connection);
            Read_Data = mySqlCommand.ExecuteReader();
            while (Read_Data.Read())
            {

                lbl_MaKh.Text = Read_Data[0].ToString();               
            }
            Read_Data.Close();
            Connection.Close();
        }

    }
}
