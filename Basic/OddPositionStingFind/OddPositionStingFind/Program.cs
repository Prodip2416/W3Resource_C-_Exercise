using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddPositionStingFind
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            var result = "";
            for (var i = 0; i < inputString.Length; i++)
            {
                if (i % 2== 0)
                {
                    result += inputString[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
