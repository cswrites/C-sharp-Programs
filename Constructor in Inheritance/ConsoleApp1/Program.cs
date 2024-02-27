using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BaseClass
    {
        public BaseClass(string message)
        {
            Console.WriteLine(message);
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass() : base("Hellow C sharp")
        {
            Console.WriteLine("This is a constructor of derived class !!");
        }
    }
  class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            Console.ReadLine();
        }
    }
}
