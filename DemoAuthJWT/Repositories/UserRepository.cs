using DemoAuthJWT.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoAuthJWT.Repositories
{
    public class UserRepository
    {
        public static IList<User> Users = new List<User>
        {

            new User
            {
                Type = 1,
                Email = "wayne@email.com",
                Name = "Wayne",
                Password = "pass@123"
            },

            new User
            {
                Type = 2,
                Email = "john@email.com",
                Name = "John",
                Password = "pass@123"
            },

            new User
            {
                Type = 3,
                Email = "paul@email.com",
                Name = "Paul",
                Password = "pass@123"
            },
        };


        public User GetByEmail(string email)
        {
            return Users.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
        }
    }
}