using System;

namespace Source
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(string login, string pswd)
        {
            Login = login;
            Password = pswd;
        }
    }
}
