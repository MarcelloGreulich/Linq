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

            List<string> listOfString = new List<string>(); 
            listOfString.Add("m"); 
            listOfString.Add("n"); 
            listOfString.Add("o"); 
            listOfString.Add("p"); 
            listOfString.Add("q");

            listOfString.Remove(listOfString.FirstOrDefault(i=> i=="o"));

            foreach (var item in listOfString)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();


        }
    }
}