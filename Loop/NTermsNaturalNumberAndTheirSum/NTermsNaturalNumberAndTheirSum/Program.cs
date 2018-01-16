using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTermsNaturalNumberAndTheirSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Text Data : ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int totalSum = 0;

            for (int i = 1; i <= userInput; i++)
            {
                Console.Write(i+" ");
                totalSum += i;
            }
            Console.WriteLine();
            Console.WriteLine("The Total Sum = {0}",totalSum);
            Console.ReadKey();
        }
    }
}
