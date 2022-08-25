using ApiTeste.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiTeste.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "Gabriel", Password = "123", Role = "manager" });
            users.Add(new User { Id = 2, Username = "Matheus", Password = "123", Role = "employee" });

            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password.ToLower() == password.ToLower()).FirstOrDefault();
        }
    }
}
