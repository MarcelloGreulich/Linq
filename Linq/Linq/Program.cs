using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;

namespace Linq
{
    internal class Program
    {



        static void Main(string[] args)
        {
            //var combine = apples.Zip(carrots, (a, c) => new { Apple = a, Carrot = c});
            //apples.Select((a,i)=> new { Apple = a, Carrot = carrots[i] });
            var set1 = new string[] { "X", "Y", "Z" };
            var set2 = new int[] { 1, 2, 3 };

            for(int i = 0; i < set1.Length; i++)
            {
                string s = (set1[i] + Convert.ToString(set2[i])); 
                Console.WriteLine(s);
            }



            Console.ReadKey();


        }
    }
}