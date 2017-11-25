using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EligebleForVote
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.Write("Input the age of the candidate : ");
            int vote_age = Convert.ToInt32(Console.ReadLine());
            if (vote_age < 18)
            {
                Console.Write("Sorry, You are not eligible to caste your vote.\n");
                Console.Write("You would be able to caste your vote after {0} year.\n", 18 - vote_age);
            }
            else
                Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
        }
    }
}
