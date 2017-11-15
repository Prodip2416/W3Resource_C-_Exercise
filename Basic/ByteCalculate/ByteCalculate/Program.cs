using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo("C:/gdc.txt");
            Console.WriteLine("Size of a file: " + f.Length.ToString());
        }
    }
}
