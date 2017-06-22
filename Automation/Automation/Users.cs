using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    class Users
    {
        public class User
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public User(string email, string password)
            {
                this.Login = email;
                this.Password = password;
            }
        }

        public static User Admin = new User("administrator", "qwerty");
        public static User VO = new User("vo", "qwerty");
    }
}
