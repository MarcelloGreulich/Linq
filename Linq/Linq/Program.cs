using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {



        static void Main(string[] args)
        {

            string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

            var lis = from a in arr1
                      group a by a.Split('.')[1] into y
                      select y;

            string extension;
            int count;
            foreach (var a in lis)
            {
                extension = a.Key;
                count = a.Count();

                Console.WriteLine($"{count} File(s) with {extension} Extension");
            }
            


            Console.ReadKey();


        }
    }
}