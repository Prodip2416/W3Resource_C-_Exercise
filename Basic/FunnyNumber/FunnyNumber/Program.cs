using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit: ");
           int num = Convert.ToInt32(Console.ReadLine());

            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();


            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);

            Console.WriteLine();

            Console.WriteLine("{0} {0} {0} {0}", num);

            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.ReadKey();
        }
    }
}
