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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int star = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            star += 1;
            circularProgressBar1.Value = star;
            circularProgressBar1.Text = Convert.ToString(star);
            if(star == 101 )
            {
                star = 0;
                timer1.Stop();
                loading_2 h = new loading_2();
                this.Hide();
                h.Show();
            }
        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
