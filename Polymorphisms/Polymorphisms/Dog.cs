using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisms
{
    internal class Dog : Animal
    {
        public Dog(string name):base(name) { }
        public override void MakeSound()
        {   
            if(Name == null || Name == ""){
                Console.WriteLine("My name is N/A and I say Arf! Arf!");
            }
            else {
                Console.WriteLine($"My name is {Name} and i say Arf! arf!");
            }
        }
    }
}
