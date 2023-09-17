using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Modifiers_2
{
    internal class uType
    {
        string Firstname, Lastname;
        int Age;
        public uType(string fname, string lname, int age) {
            Firstname = fname;
            Lastname = lname;
            Age = age;

            Console.WriteLine("User Created...");
            Console.WriteLine(Firstname+" "+Lastname);
        }
    }
}
