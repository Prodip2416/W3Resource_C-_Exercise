using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputTwoNumberOddOrEvenChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool bothEven;
            Console.Write("Input First number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());


            if (n1 % 2 == 0 && n2 % 2 == 0)
                Console.WriteLine("there're numbers bothEven");
            else
                Console.WriteLine("there's a number odd");

            ////bothEven = ((n1%2!=0) || (n1%2!=0))? false:true;
            //bothEven = ((n1 % 2 == 0)
            //    && (n2 % 2 == 0)) ? true : false;

            //Console.WriteLine(bothEven ?
            //  "there're numbers bothEven" :
            //  "there's a number odd");
        }
    }
}
