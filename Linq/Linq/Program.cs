﻿using System;
using System.Linq;

namespace Linq
{
    internal class Program
    {



        static void Main(string[] args)
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : ");
            Console.Write("\n------------------------------------------------------------------------\n");

            var sqNo = from int Number in arr1
                       let SqrNo = Number * Number
                       where SqrNo > 20
                       select new { Number, SqrNo };

            foreach (var a in sqNo)
                Console.WriteLine(a);

            Console.ReadKey();


        }
    }
}
