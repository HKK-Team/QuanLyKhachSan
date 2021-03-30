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
    public partial class loading_2 : Form
    {
        public loading_2()
        {
            InitializeComponent();
        }

        private void loading_2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int star = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            star += 5;
            progressBar1.Value = star;
            if(star == 100)
            {
                star = 0;
                timer1.Stop();
                DangNhap h = new DangNhap();
                this.Hide();
                h.Show();
            }
        }
    }
}
