using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInput an integer:");
           int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another integer:");
           int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
        }
    }
}
