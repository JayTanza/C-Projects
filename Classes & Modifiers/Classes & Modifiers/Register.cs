using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Modifiers
{
    internal class Register
    {
        public User CreateUser(string username, string password)
        {
            return new User { Username = username, Password = password };
        }
    }
}
