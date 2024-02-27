// Check Even or Odd Number
/*
Write a program that prompts the user to enter an integer and then,
determines whether the number is even or odd using logical operators.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an Integer: ");
        //int number = int.Parse(Console.ReadLine());
        int number = Convert.ToInt32(Console.ReadLine());

        if(number % 2 == 0)
        {
            Console.WriteLine("Entered number is Even.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Entered number is Odd.");
            Console.ReadLine();
        }
    }
}