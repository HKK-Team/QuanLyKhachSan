using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DoAn_LTWD_Quan_Ly_Khach_San
{
    public partial class loading : Form
    {
        string MySQLConnectionString = @"server=localhost;user id=root;password = 260601;persistsecurityinfo=True;database=ql_khach_san";
        MySqlConnection Connection;
        public loading()
        {
            InitializeComponent();
            connectionData();
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
            if(star == 100 )
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

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
        private void connectionData()
        {
            Connection = new MySqlConnection(MySQLConnectionString);
            Connection.Open();
        }
    }
}
