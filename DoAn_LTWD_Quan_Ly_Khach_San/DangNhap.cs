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
using FontAwesome.Sharp;
using Domain;
using DataAccess;

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
            btnlogin_Click(sender, e);
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            if (txtTaiKhoan.Text != "Username" && txtTaiKhoan.TextLength > 2)
            {
                if (txtMatKhau.Text != "Password")
                {
                    
                    UserModel user = new UserModel();
                    
                    var validLogin = user.LoginUser(tk,mk);
                    if (validLogin == true)
                    {

                        Wecome a = new Wecome();
                        a.Hide();
                        a.Show();
                        TrangChu b = new TrangChu();
                        b.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("! Sai tài khoản hoặc mật khẩu\n      Please try again.");
                        txtMatKhau.Text = "Password";
                        txtMatKhau.UseSystemPasswordChar = true;
                        txtMatKhau.Focus();
                    }
                }
                else msgError("Please enter password.");
            }
            else msgError("Please enter username.");
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtMatKhau.Text = "Password";
            txtMatKhau.UseSystemPasswordChar = true;
            txtTaiKhoan.Text = "Username";
            lblErrorMessage.Visible = false;
            this.Show();
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
            panel1.BackColor = Color.FromArgb(205, 198, 152);
            iconPictureBox3.ForeColor = Color.FromArgb(205, 198, 152);
            txtTaiKhoan.ForeColor = Color.FromArgb(205, 198, 152);
        }

        private void txtMatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            txtMatKhau.Clear();
            panel5.BackColor = Color.FromArgb(205, 198, 152);
            iconPictureBox4.ForeColor = Color.FromArgb(205, 198, 152);
            txtMatKhau.ForeColor = Color.FromArgb(205, 198, 152);

        }

  
        private void iconButton1_Click(object sender, EventArgs e)
        {
            var recoverPassword = new RecoverPassword();
            this.Hide();
            recoverPassword.ShowDialog();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
