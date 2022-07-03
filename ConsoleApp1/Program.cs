using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
     class Rectangle
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public Rectangle(double lenght, double width)
        {
            Lenght = lenght;
            Width = width;
        }

        public  double calculateArea()
        {
            return Lenght * Width;
        }
        public double calculatePerimeter()
        {
            return 2 * (Lenght + Width);
        }
    }
}
