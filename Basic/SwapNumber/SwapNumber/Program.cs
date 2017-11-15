using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp;

            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine();
            Console.WriteLine("After Swaping......");
            Console.WriteLine();
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
