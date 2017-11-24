using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give Radius of the circle : ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Perimeter of Circle : {0}",2*3.14*radius);
            Console.ReadLine();
        }
    }
}
