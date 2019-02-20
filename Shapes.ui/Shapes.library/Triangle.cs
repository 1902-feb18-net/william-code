using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.library
{
    class Triangle : I2D
    {
        public int sideLength { get; set; } = 3;
        public int sides { get; } = 3;
        public string name { get; set; } = "Triangle";

        public int Angle()
        {
            return (180*(sides-2))/sides;
        }

        public double Area()
        {
            return sideLength / 2 * sideLength * Math.Sqrt(3);
        }
    }
}
