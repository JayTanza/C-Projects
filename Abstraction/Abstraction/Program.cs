using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculations = true;

            while (continueCalculations)
            {
                CalculatorOfArea();

                Console.Write("Do you want to continue (Y/N)? ");
                string continueChoice = Console.ReadLine();

                if (continueChoice.ToUpper() != "Y")
                {
                    continueCalculations = false;
                }
            }
        }

        static void CalculatorOfArea() {
            string shape;

            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Shape Options:");
                Console.WriteLine("1. Calculate Area of Circle");
                Console.WriteLine("2. Calculate Area of Rectangle");
                Console.WriteLine("3. Calculate Area of Square");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1/2/3/4): ");
                shape = Console.ReadLine();

                switch (shape)
                {
                    case "1":
                        AreaofCircle();
                        validInput = true; // Valid input, exit the loop
                        break;
                    case "2":
                        AreaofRectangle();
                        validInput = true; // Valid input, exit the loop
                        break;
                    case "3":
                        AreaofSquare();
                        validInput = true; // Valid input, exit the loop
                        break;
                    case "4":
                        validInput = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option (1/2/3/4)");
                        break;
                }
            }
        }

        static void AreaofCircle() { 
            Console.WriteLine("Enter a value of Radius: ");
            double r = double.Parse(Console.ReadLine());

            Shapes c = new Circle(r);
            c.DisplayAreaofCircle();
        }

        static void AreaofRectangle()
        {
            Console.WriteLine("Enter a value of length: ");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value of width: ");
            double w = double.Parse(Console.ReadLine());

            Shapes r = new Rectangle(l,w);
            r.DisplayAreaofCircle();
        }

        static void AreaofSquare()
        {
            Console.WriteLine("Enter a value of Sidelength: ");
            double sl = double.Parse(Console.ReadLine());

            Shapes s = new Square(sl);
            s.DisplayAreaofCircle();
        }
    }
}
