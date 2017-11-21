using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = i; j <= num; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
