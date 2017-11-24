using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceTime
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input distance(meters): ");
            double distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour): ");
            double hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            double min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            double sec = Convert.ToSingle(Console.ReadLine());

            double timeSec = (hour * 3600) + (min * 60) + sec;
            double mps = distance / timeSec;
            double kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            double mph = kph / 1.609f;

            Console.WriteLine("Your speed in meters/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
        }
    }
}
