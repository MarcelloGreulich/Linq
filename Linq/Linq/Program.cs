using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace Linq
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele elemente wollen Sie hinzufügen?");
            int count = Convert.ToInt32(Console.ReadLine());
            int zahl;
            List<int> list = new List<int>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Jo geb Zahl");
                zahl = Convert.ToInt32(Console.ReadLine());
                list.Add(zahl);
            }

            Console.Clear();

            Console.WriteLine("Jogeb Meer Zal");
            int zahl2=Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

            list.Sort();
            list.Reverse();

            foreach (var n in list.Take(zahl2))
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();


        }
    }
}
