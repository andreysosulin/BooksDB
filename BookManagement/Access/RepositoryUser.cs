using System;
using System.Collections.Generic;
using System.Text;
using Source;
using System.Security.Cryptography;
using System.Linq;

namespace Access
{
    public class RepositoryUser : IRepository<User>
    {
        Context context = Context.Instance;
        public static RepositoryUser Instance { get; } = new RepositoryUser();
        public List<User> Items { get; private set; } = new List<User>();

        private RepositoryUser(){}

        public void LoadData()
        {
            foreach(User val in context.Users)
            {
                Items.Add(val);
            }
        }


        public void Add(User user)
        {
            user.Password = GetHash(user.Password);
            context.Users.Add(user);
            Items.Add(user);
            context.SaveChanges();
        }

        

        public bool Authorisation(string login, string password)
        {
            string hashPswd = GetHash(password);
            int count = Items.Where(t => t.Login == login && t.Password == hashPswd).Count();
            if (count != 0)
            {
                return true;
            }
            return false;
        }

        public string GetHash(string val)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(val));
            return Convert.ToBase64String(hash);
        }

        
    }
}
