using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Modifiers
{
    internal class Login
    {
        public bool Authenticate(User user, string enteredPassword)
        {
            return user != null && user.Password == enteredPassword;
        }
    }
}
