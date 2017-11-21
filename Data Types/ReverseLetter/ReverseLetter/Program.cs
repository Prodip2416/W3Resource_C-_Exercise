using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input letter: ");
            char letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            char letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            char letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
        }
    }
}
