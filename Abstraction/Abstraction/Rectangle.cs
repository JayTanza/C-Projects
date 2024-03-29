﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Rectangle : Shapes
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;  
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
