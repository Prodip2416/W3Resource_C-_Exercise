using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NumberCountInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] {1, 2, 3, 4, 5, 6, 2, 3, 4, 7, 8, 90, 3};
            int findNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of " + findNumber + " present in the said array");
            Console.WriteLine(numbers.Count(f=>f==findNumber));
            Console.ReadLine();
        }
    }
}
