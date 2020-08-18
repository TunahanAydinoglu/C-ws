using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2); // print 10 because value type


            string[] cities1 = new string[] { "Antalya", "Bursa", "Isparta" };
            string[] cities2 = new string[] { "Burdur", "Afyon", "Konya" };
            cities2 = cities1;

            cities1[0] = "Mugla";

            Console.WriteLine(cities2[0]); //print mugla because Referans type 

            Console.ReadLine();
        }
    }
}
