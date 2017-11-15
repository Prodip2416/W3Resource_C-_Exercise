using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexval = "4B0";
            Console.WriteLine("Hexadecimal number: " + hexval);
            int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Decimal number: " + decValue);
        }
    }
}
