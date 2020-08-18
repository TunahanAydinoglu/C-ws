using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //ListCollection();

            Dictionary();



            Console.ReadLine();
        }

        static void Dictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("kitap", "book");
            dictionary.Add("bilgisayar", "computer");
            dictionary.Add("table", "tablo");

            Console.WriteLine(dictionary["kitap"]);
        }

        static void ListCollection()
        {
            List<string> cities = new List<string>(); //type safe

            cities.Add("Antalya");
            cities.Add("Antakya");

            foreach(var i in cities)
            {
                Console.WriteLine(i);
            }

        }


        static void ArrayList()
        {
            string[] cities = new string[2] { "Ankara", "Konya" };
            // cities[2] = "Adana"; //error


            ArrayList cities2 = new ArrayList(); //Not type safe
            cities2.Add("Adana");
            cities2.Add("Ankara");

            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }
            cities2.Add(15);
            Console.WriteLine(cities2[2]);
        }
    }
}
