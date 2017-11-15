using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFirstCharacterFunny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
        }
    }
}
