using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private List<User> users;

        public BasicAuthenticationService()
        {
            users = new List<User>
            {
            new User { Username = "Alyaa", Password = "123", Role = "Admin" },
            new User { Username = "Soher", Password = "123", Role = "User" }
            };
        }
        public bool AuthenticateUser(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                    return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            foreach (var user in users)
            {
                if (user.Username == username && user.Role == role)
                    return true;
            }
            return false;
        }
    }
    
    
}
