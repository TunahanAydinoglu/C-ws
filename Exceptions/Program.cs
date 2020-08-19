using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();


            
            try
            {
                CustomException();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }




            Console.ReadLine();
        }

        private static void CustomException()
        {
            List<string> students = new List<string> { "Tunahan", "Kerem", "Bilal" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
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

                Console.WriteLine("Koddaki hata : {0}", exception.Message);

            }
        }
    }
}
