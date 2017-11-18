using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
