using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Functions_Parameters_Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App. By Jay Tanza");
            string a = Console.ReadLine();
            //int number = int.Parse(Console.ReadLine());

            switch (a)
            {
                case "a":
                    Add();
                    break;
                case "b":
                    Sub();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a key a and b");
                    break;
            }
        }
        static void Add() {
            Console.WriteLine("Enter your first number: ");
            int num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = addition(num1, num2);
            Console.WriteLine("The sum of " + num1 + "+" + num2 + " is " + sum);
        }
        static void Sub()
        {
            Console.WriteLine("Enter your first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = subtraction(num1, num2);
            Console.WriteLine("The sub of " + num1 + "+" + num2 + " is " + sum);
        }
        static int addition(int a, int b) {
            int x = a;
            int y = b;
            int sum = x + y;
            return sum;
        }
        static int subtraction(int a, int b)
        {
            int x = a;
            int y = b;
            int subtract = x + y;
            return subtract;
        }
    }
}
