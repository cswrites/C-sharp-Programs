using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{
    class BaseClass
    {
        public void Show1()
        {
            Console.WriteLine("this is the method of base class ");
        }
    }

    class DerivedClass1 : BaseClass
    {
        public void Show2()
        {
            Console.WriteLine("This is the method of 1st Derived class");
        }
    }
    class DerivedClass2 : DerivedClass1
    {
        public void Show3()
        {
            Console.WriteLine("This is the method of 2nd Derived class");
        }
    }

    class Program
    { 
        static void Main()
        {
            DerivedClass3 dc3 = new DerivedClass3();
            dc3.Show1();
            dc3.Show2();
            dc3.Show3();
            dc3.Show4();
        }
    }
}
