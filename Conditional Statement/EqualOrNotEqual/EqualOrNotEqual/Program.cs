using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualOrNotEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st number: ");
            int int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
                Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
        }
    }
}
