using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
        }
    }
}
