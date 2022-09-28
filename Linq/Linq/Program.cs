using System;

namespace Linq
{
    internal class Program
    {



        static void Main(string[] args)
        {
            int[] list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 2 == 1)
                {
                    Console.WriteLine(list[i]);
                }
            }
            Console.ReadKey();


        }
    }
}
