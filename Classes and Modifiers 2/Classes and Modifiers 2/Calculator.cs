using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Modifiers_2
{
    internal class Calculator
    {
        public int Addition(int num1, int num2) {
            Console.Write("The Result is: ");
            return num1 + num2;
        }
        public int Subtraction(int num1, int num2){
            Console.Write("The Result is: ");
            return num1 - num2;
        }
        public int Multiplacation(int num1, int num2){
            Console.Write("The Result is: ");
            return num1 * num2;
        }
        public int Division(int num1, int num2){
            Console.Write("The Result is: ");
            return num1 / num2;
        }
    }
}
