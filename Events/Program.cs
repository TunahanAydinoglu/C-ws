using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product hdd = new Product(50);
            hdd.ProductName = "HardDisk";

            Product gsm = new Product(50);
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for(int i=0; i<10; i++)
            {
                hdd.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Stock Check pls");
        }
    }

}
