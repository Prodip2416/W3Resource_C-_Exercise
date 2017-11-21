using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNumberAndTheirSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, count, userNum1, userNum2,result=0;

            Console.Write("Starting Number : ");
            userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ending Number: ");
            userNum2 = Convert.ToInt32(Console.ReadLine());
           // Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);

            for (num = userNum1; num <= userNum2; num++)
            {
                count = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && num != 1)
                {
                    result += num;
                    Console.Write("{0} ", num);
                }
            }
            
            Console.Write("\n");

            Console.WriteLine("Sum = {0}",result);

        }
    }
}
