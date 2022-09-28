using System;
using System.Linq;

namespace Linq
{
    internal class Program
    {



        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var cit = from c in cities
                      where c.StartsWith("C") && c.EndsWith("A")
                      select c;
            foreach (var nu in cit) { 
                Console.WriteLine(nu);
            }

            Console.ReadKey();


        }
    }
}
