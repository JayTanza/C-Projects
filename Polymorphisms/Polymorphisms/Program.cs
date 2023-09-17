using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of animals
            List<Animal> animals = new List<Animal>
        {
            new Dog("Buddy"),
            new Dog("Max"),
        };

            // Make each animal speak using polymorphism
            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}");
                animal.MakeSound();
                Console.WriteLine(); // Add a blank line for separation
            }

        }
    }
}
