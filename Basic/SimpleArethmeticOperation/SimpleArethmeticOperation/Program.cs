using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArethmeticOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("First Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}",num1,num2,num1+num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
            Console.ReadKey();
        }
    }
}
