using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumTriple(2, 2));
            Console.WriteLine(SumTriple(12, 10));
            Console.WriteLine(SumTriple(-5, 2));
            Console.ReadKey();
        }
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
    }
}
