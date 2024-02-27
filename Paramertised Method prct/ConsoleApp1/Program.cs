// Checking the number is even or not.

using System;
class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        bool isEven = IsEven(number);
        if(isEven)
        {
            Console.WriteLine($"{number} is an even number.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
            Console.ReadLine();
        }
    }
    static bool IsEven(int num)
    {
        return num % 2 == 0;
        
    }
    
}