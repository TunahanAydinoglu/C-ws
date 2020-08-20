using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla(3, 4));
            //Console.WriteLine(dortIslem.Topla2());

            var type = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,4,7);
            //Console.WriteLine(dortIslem.Topla(2,6));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(type,11,2);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
               var result =  methodInfo.Invoke(instance,null);

            Console.WriteLine(result);

            var methods = type.GetMethods();
            foreach(var i in methods)
            {
                Console.WriteLine(i.Name);
                foreach(var parameterInfo in i.GetParameters() )
                {
                    Console.WriteLine(parameterInfo.Name);
                }
            }

        }
    }


    public class DortIslem
    {
        public DortIslem()
        {

        }
        private int _sayi1 = 1;
        private int _sayi2 = 1;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

}
