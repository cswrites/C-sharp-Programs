using System;
namespace MethodInCsharp
{
    class Program
    {
        public void Show()      //Method Declaration
        {
            Console.WriteLine("Welcome to C sharp programing");
        }


        static void Main()
        {
            Program p1 = new Program();
            p1.Show();
            Console.ReadLine();
        }
    }
}