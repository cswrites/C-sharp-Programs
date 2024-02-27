using System;

class Program
{
    public static void ShowName(string name ="Unknown")  // Unknown is an optional parameter.
    {
        Console.WriteLine("Your name is: " +name);
    }
    static void Main()
    {
        Program.ShowName();
        Console.ReadLine();
    }
}