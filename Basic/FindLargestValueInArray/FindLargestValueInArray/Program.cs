using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargestValueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Largest Value between first anh last element
            int[] nums = { 1, 2,56 ,5, 7, 8 };
            var findResult = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > nums[0])
                {
                    findResult = nums[i];
                }
            }
            Console.WriteLine(findResult);
        }
    }
}
