using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAndTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("The table is : {0} x {1} = {2}", x, 1, x * 1);
            Console.WriteLine("               {0} x {1} = {2}", x, 2, x * 2);
            Console.WriteLine("               {0} x {1} = {2}", x, 3, x * 3);
            Console.WriteLine("               {0} x {1} = {2}", x, 4, x * 4);
            Console.WriteLine("               {0} x {1} = {2}", x, 5, x * 5);
            Console.WriteLine("               {0} x {1} = {2}", x, 6, x * 6);
            Console.WriteLine("               {0} x {1} = {2}", x, 7, x * 7);
            Console.WriteLine("               {0} x {1} = {2}", x, 8, x * 8);
            Console.WriteLine("               {0} x {1} = {2}", x, 9, x * 9);
            Console.WriteLine("               {0} x {1} = {2}", x, 10, x * 10);
            Console.ReadKey();
        }
    }
}
