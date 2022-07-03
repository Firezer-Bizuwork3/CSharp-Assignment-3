using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
     class Circle
    {
        public double radius { get; set; }
        public static readonly double PI = 3.14;
        double calculateArea()
        {
            return PI * Math.Pow(radius, 2);
        }
        double calucatePerimeter()
        {
            return PI * 2 * radius;
        }
    }
}
