// Check Eligibility for Voting.
/*  Write a program to determine if a person is eligible to vote based on their age
  (assuming the legal voting age is 18).
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");
        //int age = Convert.ToInt32(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());

        if(age>=18)
        {
            Console.WriteLine("Your are eligible to vote.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You are not eligible to vote yet.");
            Console.ReadLine();
        }
    }
}