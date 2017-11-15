using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(x % 3 == 0 || x % 7 == 0);
            }
        }
    }
}
