using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.library
{
    public interface I2D
    {
        int sideLength { get; set; }
        int sides { get; }
        string name { get; set; }

        int Angle();
        double Area();
    }
}
