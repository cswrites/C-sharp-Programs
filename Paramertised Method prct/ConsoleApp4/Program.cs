// Intermediate Program: Finding Factorial with Parameterized Method.

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to find its factorial: ");
        int number = int.Parse(Console.ReadLine());

        long factorial = CalculateFactorial(number);
        Console.WriteLine($"Factorial of {number} is: {factorial}");
        Console.ReadLine();
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n*CalculateFactorial(n - 1);
    }
}