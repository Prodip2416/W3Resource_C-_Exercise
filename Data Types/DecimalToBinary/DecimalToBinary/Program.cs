using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User Input : ");
            int value = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine("Number to convert Binary : {0}", binary);
        }
    }
}
