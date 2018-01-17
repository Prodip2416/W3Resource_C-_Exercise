using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OddNaturalNumberTheirSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Target : ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <=userInput; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", userInput, sum);
        }
    }
}
