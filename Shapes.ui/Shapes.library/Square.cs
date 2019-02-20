using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.library
{
    class Square : I2D
    {
        public int sideLength { get; set; } = 4;

        public int sides = 4;

        public string name { get; set; } = "Square";

        public int Angle()
        {
            return (180*(sides - 2))/sides;
        }

        public double Area()
        {
            return sideLength ^ 2;
        }
    }
}
