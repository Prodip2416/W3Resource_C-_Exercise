using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UserPassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // If User Input Console.....

            //Console.Write("Please Enter UserId = ");
            //string userId = Console.ReadLine();
            //Console.Write("Please Enter UserPass = ");
            //string userPass = Console.ReadLine();


            string userId = "2416";
            string userPass = "Prodip";
            Console.WriteLine();
            Console.WriteLine("Please Enter Valide UserId = {0} and Password = {1}", userId, userPass);
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < 3; i++)
            {

                Console.Write("Please Enter UserID : ");
                string userId1 = Console.ReadLine();
                Console.Write("Please Enter UserPass : ");
                string userPass1 = Console.ReadLine();

                if (userId == userId1 && userPass == userPass1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratualtion..... {0}", userPass);
                    break;
                }
                Console.WriteLine("Try Again");
                Console.WriteLine("----------------------------------------------");
                count++;
            }
            if (count == 3)
                Console.WriteLine("user will be rejected");
            Console.WriteLine("------------------------------------------");


        }

    }
}
