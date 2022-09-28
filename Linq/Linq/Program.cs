using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Linq
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Gebbe einen satz mit UPPER CASE wörtern ein");
            string count = Console.ReadLine();

            Console.Clear();

            //[Das, ist , ]
            count
                .Split(' ')
                //Check if All Letters are UPPER
                .Where(e=>e.All(char.IsUpper))
                //Convert to List 
                .ToList()
                //Print 
                .ForEach(f=> Console.WriteLine(f));

            Console.ReadKey();



        }
    }
}