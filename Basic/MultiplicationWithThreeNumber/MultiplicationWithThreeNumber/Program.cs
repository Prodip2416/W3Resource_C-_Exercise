using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationWithThreeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("FirstNumber : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("SecondNumber : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ThiredNumber : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} x {1} x {2} = {3}",num1,num2,num3,num1*num2*num3);
            Console.ReadKey();
        }
    }
}
