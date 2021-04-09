using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using Data_Access;

namespace DataAccess
{
    public class UserDao : ConnectionToSql
    {

        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from admin where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            
                            UserCache.LoginName = reader.GetString(0);
                            UserCache.Password = reader.GetString(1);
                            UserCache.IdUser = reader.GetInt32(2);
                            UserCache.FirstName = reader.GetString(3);
                            UserCache.LastName = reader.GetString(4);
                            UserCache.Position = reader.GetString(5);
                            UserCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public void editProfile(int id, string userName, string password, string name, string lastName, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update admin set LoginName=@userName, Password=@pass, FirstName=@name, LastName=@lastName, Email=@mail where UserID=@id";
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from admin where LoginName=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(1);
                        var mailService = new SystemSupportMail();
                        mailService.sendMail(
                          subject: "HỆ THỐNG: Yêu cầu khôi phục mật khẩu",
                          body: "Hi, " + userName + "\nBạn đã yêu cầu khôi phục mật khẩu của mình. \n" +
                          "mật khẩu hiện tại của bạn là: " + accountPassword +
                          "\nTuy nhiên, chúng tôi yêu cầu bạn thay đổi mật khẩu của mình ngay lập tức sau khi bạn vào hệ thống.",
                          recipientMail: new List<string> { userMail }
                          );

                        return "Hi, " + userName + "\nBạn đã yêu cầu khôi phục mật khẩu của mình.\n" +
                          "Vui lòng kiểm tra thư của bạn : " + userMail +
                          "\nTuy nhiên, chúng tôi yêu cầu bạn thay đổi mật khẩu của mình ngay lập tức sau khi bạn vào hệ thống.";
                    }
                    else
                        return "Xin lỗi, bạn không có tài khoản với Email hoặc tên người dùng đó";
                }
            }
        }

    }


}

