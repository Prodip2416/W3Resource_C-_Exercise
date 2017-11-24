using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingLowerCaseOrDigit
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.Write("Input a symbol: ");
            char userInput = Convert.ToChar(Console.ReadLine());

            if ((userInput == 'a') || (userInput == 'e') || (userInput == 'i') ||
                    (userInput == 'o') || (userInput == 'u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((userInput >= '0') && (userInput <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");
        }
    }
}
