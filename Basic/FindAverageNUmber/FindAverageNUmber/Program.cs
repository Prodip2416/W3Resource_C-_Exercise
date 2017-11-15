using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAverageNUmber
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter the First number: ");
           int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number: ");
           int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
           int number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the four number: ");
           int number4 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("The average of {0} , {1} , {2} , {3} is: {4} ",
         number1, number2, number3, number4, (number1 + number2 + number3 + number4) / 4);
        }
    }
}
