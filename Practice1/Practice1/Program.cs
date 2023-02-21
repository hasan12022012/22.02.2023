using System;
using System.Collections.Generic;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string opt;
            do
            {
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Telebelere bax");
                Console.WriteLine("3. Telebelerin ortalamasina bax");
                Console.WriteLine("0. Menudan cix");

                Console.WriteLine("\nSecim edin:");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":

                        Console.Write("FullName: ");
                        string fullname = Console.ReadLine();
                        Console.Write("GroupNo: ");
                        string groupNo = Console.ReadLine();

                        byte point;
                        string pointStr;
                        do
                        {
                            Console.Write("Point: ");
                            pointStr = Console.ReadLine();
                        } while (!byte.TryParse(pointStr, out point) || point > 100 || point < 0);



                        Student std1 = new Student
                        {
                            FullName = fullname,
                            Group = groupNo,
                            Point=point
                        };

                        students.Add(std1);
                        break;
                    case "2":
                        foreach (var item in students)
                            Console.WriteLine(item);
                        break;
                    case "3":
                        if (students.Count == 0)
                        {
                            Console.WriteLine("Telebe yoxdur!");
                            break;
                        }
                        double sum = 0;
                        foreach (var item in students)
                        {
                            sum += item.Point;
                        }

                        Console.WriteLine(sum / students.Count);
                        break;
                    case "0":
                        Console.WriteLine("Menudan cixdiniz");
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir");
                        break;
                }

            } while (opt != "0");
        }
    }
}
