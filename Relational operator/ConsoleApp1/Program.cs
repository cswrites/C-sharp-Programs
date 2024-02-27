// Comparing Two Numbers
/*
 Write a program that prompts the user to enter two numbers 
and then determines whether the first number is greater than, less than, or equal to the second number 
using relational operators. 
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
    
        if(num1 > num2)
        {
            Console.WriteLine($"{num1} is greater than {num2}");
            Console.ReadLine();
        }
        else if(num1 < num2)
        {
            Console.WriteLine($"{num1} is less than {num2}");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"{num1} is equal to {num2}");
            Console.ReadLine();
        }
    }
}