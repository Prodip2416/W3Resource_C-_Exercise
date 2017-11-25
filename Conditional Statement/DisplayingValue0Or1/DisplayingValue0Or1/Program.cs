using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayingValue0Or1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
           
            Console.Write("Input the  value of m :");
            m = Convert.ToInt32(Console.ReadLine());
            if (m != 0)
                if (m > 0)
                    n = 1;
                else
                    n = -1;
            else
                n = 0;
            Console.Write("The value of m = {0} \n", m);
            Console.Write("The value of n = {0} \n", n);
        }
    }
}
