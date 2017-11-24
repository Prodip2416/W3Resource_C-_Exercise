using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
           int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation [+ , - , *, /] Any One : ");
           char operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
           int y = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Wrong Character");
        }
    }
}
