using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] { "Tunahan", "Furkan", "Ramazan" };

                students[3] = "Mehmet"; // error
            }
            catch (DivideByZeroException excep)
            {
                Console.WriteLine(excep.Message);
            }
            catch (IndexOutOfRangeException excep)
            {
                Console.WriteLine(excep.Message);
            }
            catch (Exception exception)
            {

                Console.WriteLine("Koddaki hata : {0}",exception.Message);

            }

            Console.ReadLine();
        }
    }
}
