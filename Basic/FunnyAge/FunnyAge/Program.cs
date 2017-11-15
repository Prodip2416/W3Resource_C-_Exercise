using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunnyAge
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than {0} ", age);
            Console.ReadKey();
        }
    }
}
