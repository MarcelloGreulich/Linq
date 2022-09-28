using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {



        static void Main(string[] args)
        {

            List<Students> students = new List<Students>();
            students.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            students.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            students.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            students.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            students.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            students.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            students.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            students.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            students.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            students.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            int count = Convert.ToInt32(Console.ReadLine());
            switch (count)
            {
                case 1:
                    count = 900;
                    break;
                case 2:
                    count = 800;
                    break;
                case 3:
                    count = 750;
                    break;
                case 4:
                    count = 700;
                    break;
                case 5:
                    count = 597; 
                    break;
                case 6:
                    count = 458; 
                    break;

            }
            var stu = from s in students
                      group s by s.GrPoint into y
                      orderby y.Key descending
                      select y;

            foreach (var h in stu)
            {
                if (count == h.Key)
                {
                    switch (h.Key)
                    {
                        case 900:
                            foreach (var x in h)
                            {
                                Console.WriteLine($" Der/Die Schüler/in {x.StuName} hat {x.GrPoint} Punkte");
                            }
                            break;
                        case 800:
                            foreach (var x in h)
                            {
                                Console.WriteLine($" Der/Die Schüler/in {x.StuName} hat {x.GrPoint} Punkte");
                            }
                            break;
                        case 750:
                            foreach (var x in h)
                            {
                                Console.WriteLine($" Der/Die Schüler/in {x.StuName} hat {x.GrPoint} Punkte");
                            }
                            break;
                        case 700:
                            foreach (var x in h)
                            {
                                Console.WriteLine($" Der/Die Schüler/in {x.StuName} hat {x.GrPoint} Punkte");
                            }
                            break;
                        case 597:
                            foreach (var x in h)
                            {
                                Console.WriteLine($" Der/Die Schüler/in {x.StuName} hat {x.GrPoint} Punkte");
                            }
                            break;
                        case 458:
                            foreach (var x in h)
                            {
                                Console.WriteLine($" Der/Die Schüler/in {x.StuName} hat {x.GrPoint} Punkte");
                            }
                            break;

                    }

                }


            }


            Console.ReadKey();


        }
    }
}