using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProblems_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Count of Users: ");
            int count = int.Parse(Console.ReadLine());

            int[] Numbers = new int[count];

            for (int i = 0; i < Numbers.Length; i++) {
                Console.WriteLine("Count: "+(i+1));
                Numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Number Display: ");
            foreach (int i in Numbers) {
                Console.WriteLine(i);
            }
        }
    }
}
