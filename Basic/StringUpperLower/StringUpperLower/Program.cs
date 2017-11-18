using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUpperLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            if (str.Length < 4)
                Console.WriteLine(str.ToUpper());
            else
                Console.WriteLine(str.ToLower());
        }
    }
}
