using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
namespace DoAn_LTWD_Quan_Ly_Khach_San
{
    public partial class RecoverPassword : Form
    {
        public RecoverPassword()
        {
            InitializeComponent();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            
                var user = new UserModel();
                var result = user.recoverPassword(txtEmail.Text);
                lblResult.Text = result;
          
        }
        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            DangNhap h = new DangNhap();
            this.Hide();
            h.Show();
        }
    }
}
