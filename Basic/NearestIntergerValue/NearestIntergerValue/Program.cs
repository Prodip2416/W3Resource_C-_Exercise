using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestIntergerValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            int n = 20;
            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);
            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
        }
    }
}
