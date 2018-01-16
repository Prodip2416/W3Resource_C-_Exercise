using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeTheNumberUptoGivenInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, ctr;
            Console.Write("\n");
            Console.Write("Display the cube of the number:\n");
            Console.Write("---------------------------------");
            Console.Write("\n");

            Console.Write("Input number of terms : ");
            ctr = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= ctr; i++)
            {
                Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
            }
        }
    }
}
