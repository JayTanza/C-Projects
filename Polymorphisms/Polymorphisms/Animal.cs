using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisms
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal(string name) {
            Name = name;
        }
        public virtual void MakeSound() {
            Console.WriteLine($"The {Name} makes a generic animal sound.");
        }
    }
}
