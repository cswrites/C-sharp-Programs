using System;
namespace ConsoleApplication
{
    class Program
    {
        static int Sum(int x, int y)
        {
            int a = x;
            int b = y;

           int result = a + b;
            return result;
        }
        static void Main()
        {
            int a = 10;
            int b = 21;
            int result = Sum(a, b);
            Console.WriteLine("The value of the sum is " + result);
            Console.ReadLine();
        }
    }
}