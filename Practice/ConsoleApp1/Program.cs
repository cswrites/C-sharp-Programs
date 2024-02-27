using System;
class Program
{
    static int AddNumber(int a, int b)
    {
        return a + b;
    }

    static double MultiplyNumber(double a, double b)
    {
        return a * b;
    }
    static void Main()
    {
        int result = AddNumber(5, 4);
        Console.WriteLine("result of addition: " +result);

        double product = MultiplyNumber(10.2, 21.5);
        Console.WriteLine("result of multiplication: " +product);
        Console.ReadLine();
    }
}