using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "izmir", "Adana");
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
            List<Product> result2 = utilities.BuildList<Product>(new Product { Name="Laptop"}, new Product { Name="Mouse"});
            foreach (var i in result2)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items) {
            return new List<T>(items);
        }
    }
    class Product : IEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
    }

    //interface IProductDal
    //{
    //    List<Product> GetAll();
    //    Product Get(int id);
    //    void Add(Product product);
    //    void Delete(Product product);
    //    void Update(Product product);
    //}
    interface IProductDal : IRepository<Product>
    {

    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    interface IStudentDal : IRepository<Student> //string yazilmasi istenilen bir durum degildir 
    {

    }
    class Student:IEntity
    {

    }
    interface IEntity
    {

    }
    interface IRepository<T> where T:class, IEntity, new() // newlenebilir olmasi durumda string engellenmis olur
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

}
