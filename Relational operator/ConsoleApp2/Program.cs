// Check Passing Marks.
/*
Write a program to check if a student has passed an exam based on the marks obtained. 
Assume passing marks are 40.
*/

using System;
class Program
{
    static void Main(string[]args )
    {
        Console.WriteLine("Enter the marks obtained: ");
        int marks = Convert.ToInt32(Console.ReadLine());
    
        if(marks>=40)
        {
            Console.WriteLine("Congratulations! You have passed the exam.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Sorry, You have failed in the exam.");
            Console.ReadLine();
        }
    }
}