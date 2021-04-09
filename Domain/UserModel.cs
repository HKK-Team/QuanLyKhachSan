using System;
using DataAccess;
namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        //Attributes
        private int idUser;
        private string loginName;
        private string password;
        private string firstName;
        private string lastName;
        private string position;
        private string email;

        //Constructors
        public UserModel(int idUser, string loginName, string password, string firstName, string lastName, string position, string email)
        {
            this.idUser = idUser;
            this.loginName = loginName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
            this.email = email;
        }

        public UserModel()
        {

        }

        //Methods
        public string editUserProfile()
        {
            try
            {
                userDao.editProfile(idUser, loginName, password, firstName, lastName, email);
                LoginUser(loginName, password);
                return "Your profile has been successfully updated";
            }
            catch (Exception ex)
            {
                return "Username is already registered, try another";
            }
        }
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }

    }
}
