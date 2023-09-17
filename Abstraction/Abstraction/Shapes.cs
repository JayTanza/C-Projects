using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Shapes
    {
        public abstract double CalculateArea();

        public void DisplayAreaofCircle() { 
            double area = CalculateArea();
            Console.WriteLine($"Area of Circle: {area}");
        }

        public void DisplayAreaofRectangle() {
            double area = CalculateArea();
            Console.WriteLine($"Area of Rectangle: {area}");
        }

        public void DisplayAreaofSquare()
        {
            double area = CalculateArea();
            Console.WriteLine($"Area of Square: {area}");
        }
    }
}
