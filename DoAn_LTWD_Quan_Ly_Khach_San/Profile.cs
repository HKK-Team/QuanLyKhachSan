using DataAccess;
using Domain;
using MySql.Data.MySqlClient;
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
    public partial class Profile : Form
    {
  
        public Profile()
        {
          
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            loadUserData();
            initializePassEditControls();
        }
        private void loadUserData()
        {
            //View
            txt_User.Text = UserCache.LoginName;
            txt_Fname.Text = UserCache.FirstName;
            txt_Lname.Text = UserCache.LastName;
            txt_Email.Text = UserCache.Email;
            txt_Position.Text = UserCache.Position;
        }
        private void loadUserEditData()
        {
            txt_EUser.Text = UserCache.LoginName;
            txt_EFname.Text = UserCache.FirstName;
            txt_ELname.Text = UserCache.LastName;
            txt_EEmail.Text = UserCache.Email;
            /*txt_EPasswordd.Text = "";
            txt_EConfirmPassword.Text = "";
            txt_ECurrentPassword.Text = "";*/
        }
        private void initializePassEditControls()
        {
            LinkEditPass.Text = "Edit";
            txt_EPasswordd.UseSystemPasswordChar = true;
            txt_EPasswordd.Enabled = false;
            txt_EConfirmPassword.UseSystemPasswordChar = true;
            txt_EConfirmPassword.Enabled = false;
            txt_ECurrentPassword.UseSystemPasswordChar = true;
            
        }
        private void reset()
        {
            loadUserData();
            initializePassEditControls();
        }

        private void linkEdit_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            loadUserEditData();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkEditPass.Text == "Edit")
            {    
                LinkEditPass.Text = "Cancel";
                txt_EPasswordd.Enabled = true;
                txt_EPasswordd.Text = "";
                txt_EConfirmPassword.Enabled = true;
                txt_EConfirmPassword.Text = "";

                linkShowPassWord.Text = "show";
                linkShowPassWord.Visible = true;
            }
            else if (LinkEditPass.Text == "Cancel")
            {
                initializePassEditControls();
                txt_EPasswordd.Text = "";
                txt_EConfirmPassword.Text = "";
                linkShowPassWord.Visible = false;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_EUser.Clear();
            txt_EPasswordd.Clear();
            txt_ELname.Clear();
            txt_EFname.Clear();
            txt_EEmail.Clear();
            txt_ECurrentPassword.Clear();
            txt_EConfirmPassword.Clear();
        }

        private void linkShowPassWord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkShowPassWord.Text == "show")
            {
                linkShowPassWord.Text = "hidden";
                txt_EPasswordd.UseSystemPasswordChar = false;
                txt_ECurrentPassword.UseSystemPasswordChar = false;
                txt_EConfirmPassword.UseSystemPasswordChar = false;

            }
            else if (linkShowPassWord.Text == "hidden")
            {
                linkShowPassWord.Text = "show";
                txt_EPasswordd.UseSystemPasswordChar = true;
                txt_ECurrentPassword.UseSystemPasswordChar = true;
                txt_EConfirmPassword.UseSystemPasswordChar = true;

            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_EPasswordd.Text.Length >= 5)
            {
                if (txt_EPasswordd.Text == txt_EConfirmPassword.Text)
                {
                    if (txt_ECurrentPassword.Text == UserCache.Password)
                    {
                        var userModel = new UserModel(
                            idUser: UserCache.IdUser,
                            loginName: txt_User.Text,
                            password: txt_EPasswordd.Text,
                            firstName: txt_Fname.Text,
                            lastName: txt_Lname.Text,
                            position: null,
                            email: txt_Email.Text);
                        var result = userModel.editUserProfile();
                        MessageBox.Show(result);
                        reset();
                        panel1.Visible = false;
                    }
                    else
                        MessageBox.Show("Icorrect current password, try again");
                }
                else
                    MessageBox.Show("The password do not match, try again");
            }
            else
                MessageBox.Show("The password must have a minimum of 5 characters");
        }
    }
}
