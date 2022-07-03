using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape cir = new Circle(2);
            Shape rec = new Rectangle(2, 3);

            Console.WriteLine("The area of the circle is" + cir.calculateArea());
            Console.WriteLine("The perimeter of the circle is" + cir.calculatePerimeter());

            Console.WriteLine("The area of the rectangle is" + rec.calculateArea());
            Console.WriteLine("The perimeterof the rectangle is" + rec.calculatePerimeter());

            Console.ReadKey();
        }
    }
}
