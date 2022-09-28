using System;
using System.Linq;

namespace Linq
{
    internal class Program
    {



        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var num = from int Number in arr1
                      group Number by Number into n
                      select n;
            foreach (var a in num) { 
                Console.WriteLine($"Number {a.Key} ist {a.Count()} vorhanden");
            }

            Console.ReadKey();


        }
    }
}
