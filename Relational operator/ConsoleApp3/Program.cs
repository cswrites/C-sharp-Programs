// Find the Largest Number.
/* 
Write a program to find the largest number among three numbers entered by the user.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the secound number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
    
        if((num1>num2) & (num1>num3))
        {
            Console.WriteLine("Number one is largest.");
            Console.ReadLine();
        }
        if((num2>num3) & (num2>num1))
        {
            Console.WriteLine("Number two is largest.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Number three is greater.");
            Console.ReadLine();
        }
    }
}