using System;
using System.Linq;

namespace Linq
{
    internal class Program
    {



        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };;

            var num = from n in nums
                      group n by n into p
                      select p;
            foreach (var nu in num) { 
                Console.WriteLine($" {nu.Key}  {nu.Sum()} {nu.Count()} ");
            }

            Console.ReadKey();


        }
    }
}
