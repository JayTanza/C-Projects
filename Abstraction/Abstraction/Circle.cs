using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Circle : Shapes
    {
        public double Radius { get; set; }
        public Circle(double radius) {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            double approximatePi = 3.14159265359;
            return approximatePi * Radius * Radius;
        }
    }
}
