using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class UserService
    {
        public User AddUser(int role,  string email, string password, string name, string lastName)
        {
            User user = new User { RoleId = role, Email = email, Password = password, FirstName = name, LastName = lastName};
            using (Context context = new Context())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            return user;
        }
    }
}
