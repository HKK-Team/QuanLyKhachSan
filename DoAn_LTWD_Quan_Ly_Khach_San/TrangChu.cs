using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DoAn_LTWD_Quan_Ly_Khach_San
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

            if (pn_right.Width == 280)
            {
                timer1.Start();
            }
            else
                timer2.Start();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có thực sự muốn thoát chương trình hay không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (a == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            
        }
        private void btn_maxizine_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_restore.Visible = true;
            btn_maxizine.Visible = false;
        }
        private void btn_restore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restore.Visible = false;
            btn_maxizine.Visible = true;
        }

        private void btn_mixinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pn_center_Paint(object sender, PaintEventArgs e)
        {

        }
        private void show(object Formhijo)
        {
            if (this.pn_center.Controls.Count > 0)
                this.pn_center.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pn_center.Controls.Add(fh);
            this.pn_center.Tag = fh;
            fh.Show();
        }
        private void pn_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            //show(new TrangChu_2());
        }

        private void icon_menu_Click(object sender, EventArgs e)
        {
            //show(new TrangChu_2());
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            pn_right.Width -= 20;
            if (pn_right.Width <= 60)
            {
                timer1.Stop();
                pn_right.Width = 70;
            }
       
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pn_right.Width += 20;
            if(pn_right.Width >= 280)
            {
                timer2.Stop();
               pn_right.Width = 280;
            }
        }
    }
}
