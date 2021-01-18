using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = @"Data Source=HUYNHDUCHUY-PC\SQLEXPRESS;Initial Catalog=QL_KhachSan;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.dataSet3.PHONG);
            ketnoi = new SqlConnection(chuoiketnoi);
            ShowData();
        }
        public void ShowData()
        { 
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"Select MAKH, HOTEN, SOCMND, NGAYDEN, MAPHONG FROM KHACHHANG";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;

            }
            ketnoi.Close();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimKiemTheoMaPhong_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = "Select MAKH, HOTEN, SOCMND, NGAYDEN, MAPHONG FROM KHACHHANG Where (MAPHONG like '%" + cbMaPhong.Text + "%')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;

            }
            ketnoi.Close();
        }

        private void btnTimKiemTheoHoTen_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = "Select MAKH, HOTEN, SOCMND, NGAYDEN, MAPHONG FROM KHACHHANG Where (HOTEN like '%" + txtHoTen.Text + "%')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketnoi.Close();
        }
        
        private void listView1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có thực sự muốn thoát chương trình hay không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (a == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có thực sự muốn thoát chương trình hay không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(a ==DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }    
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            sql = @"Select PHONG.MAPHONG,KHACHHANG.HOTEN, DATEDIFF(DAY,KHACHHANG.NGAYDEN,GETDATE()),DATEDIFF(DAY,KHACHHANG.NGAYDEN,GETDATE()) *PHONG.DONGIA 
FROM PHONG Inner Join KHACHHANG  
ON PHONG.MAPHONG = KHACHHANG.MAPHONG
Where (KHACHHANG.MAPHONG = N'" + cbMaPhong.Text + @"') and (KHACHHANG.HOTEN = N'" + txtHoTen.Text + @"')";
            thuchien = new SqlCommand(sql,ketnoi);
            docdulieu = thuchien.ExecuteReader();
            while(docdulieu.Read())
            {
                lbphong.Text = docdulieu[0].ToString();
                lbngay.Text = docdulieu[2].ToString();
                lbtongtien.Text = docdulieu[3].ToString();
                i++;
            }
            ketnoi.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaPhong.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtHoTen.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
