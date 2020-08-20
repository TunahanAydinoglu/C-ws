using System;
using System.ComponentModel.DataAnnotations;

namespace Atttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Aydinoglu", Age = 23 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();

            Console.WriteLine("Hello World!");
        }


    }

    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Id},{customer.FirsName},{customer.LastName},{customer.Age}");
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field,AllowMultiple =false)]
    class RequiredPropertyAttribute : Attribute
    {

    }
}
