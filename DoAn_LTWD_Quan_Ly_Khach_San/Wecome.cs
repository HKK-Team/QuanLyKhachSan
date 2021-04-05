using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace DoAn_LTWD_Quan_Ly_Khach_San
{
    public partial class Wecome : Form
    {
        public Wecome()
        {
            InitializeComponent();
            loadDataUser();
        }

        private void Wecome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int s = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            s += 5;
            progressBar1.Value = s;
            if(s == 150)
            {
                s = 0;
                timer1.Stop();
                TrangChu a = new TrangChu();
                a.Hide();
                a.Show();
            }    
        }
        public void loadDataUser()
        {
            lbl_Lname.Text = UserCache.LastName +" , " + UserCache.FirstName;
        }
    }
}
