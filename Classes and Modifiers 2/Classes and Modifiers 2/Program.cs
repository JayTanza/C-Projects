using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Modifiers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uType type = new uType("jay","tanza",22);
            //calculatorApp();
            UserRegistration();
        }
        
        static void UserRegistration()
        {
            

            //Set user details using setters
            Console.WriteLine("Input your firstname: ");
            string fname = Console.ReadLine();

            Console.WriteLine("Input your lastname: ");
            string lname = Console.ReadLine();

            Console.WriteLine("Input your age: ");
            int age = int.Parse(Console.ReadLine());

            User user = new User(fname,lname,age);

            //user.FirstName = fname;
            //user.LastName = lname;
            //user.Age = age;

            Console.WriteLine("Display User Details: ");
            user.DisplayUserDetails();
        }
        static void calculatorApp() {
            Calculator calculator = new Calculator();
            Console.WriteLine("Input your first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Select an Operation + - * /");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(calculator.Addition(num1, num2));
                    break;
                case "-":
                    Console.WriteLine(calculator.Subtraction(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(calculator.Multiplacation(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(calculator.Division(num1, num2));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
