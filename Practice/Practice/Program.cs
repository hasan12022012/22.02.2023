using System;
using System.Collections.Generic;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();
            string opt;
            do
            {
                Console.WriteLine("1.Mehsul elave et:");
                Console.WriteLine("2.Butun mehsullara bax:");
                Console.WriteLine("3.Secilmis mehsula bax:");
                Console.WriteLine("0.Menudan cix");

                Console.WriteLine("\nSecim edin:");
                opt= Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        string namePr;
                        do
                        {
                            Console.WriteLine("Mehsulun adini daxil edin:");
                            namePr = Console.ReadLine();
                        } while (products.ContainsKey(namePr));
                        

                        Console.WriteLine("Mehsulun qiymetini daxil edin:");
                        string price=Console.ReadLine();
                        double pricePr=Convert.ToDouble(price);

                        products.Add(namePr, pricePr);
                        break; 

                    case "2":
                        foreach(var item in products)
                        {
                            Console.WriteLine(item.Key+" - "+item.Value);
                        }
                        break;

                    case "3":
                        namePr=Console.ReadLine();
                        if (!products.ContainsKey(namePr))
                        {
                            Console.WriteLine($"{namePr} adli mehsul yxodur");
                            break;
                        }
                        Console.WriteLine(namePr+" - " + products[namePr]);

                        break;

                    case "0":
                        Console.WriteLine("Menudan cixdiniz");
                        break;

                    default:
                        Console.WriteLine("Seciminiz yanlisdir");
                        break;
                }

            } while (opt!="0");
        }
    }
}
