using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new[] {1, 2, 3, 4, 5, 6, 7};
            Console.WriteLine(numbers[0]==num|| numbers[numbers.Length-1]==num);
        }
    }
}
