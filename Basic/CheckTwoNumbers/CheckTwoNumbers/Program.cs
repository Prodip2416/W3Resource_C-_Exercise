using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a first number(<100): ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number(>100): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((m < 100 && n > 200));
        }
    }
}
