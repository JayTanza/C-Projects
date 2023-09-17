using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Square : Shapes
    {
        public double SideLength { get; set; }
        public Square(double sidelength)
        {
            SideLength = sidelength;
        }

        public override double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
