using System;
class Program
{
    public Program()
    {
        Console.WriteLine("The first constructor");
    }
    public Program(int a, int b)
    {
        Console.WriteLine("The secound constructor is invoked now: {0}", (a + b));
    }
    public Program(int a, int b, int c)
    {
        Console.WriteLine("The third constructor is invoked now: {0}", (a + b + c));
    }
    public Program(string a, string b, string c)
    {
        Console.WriteLine("The fourth constructor is invoked now: {0}",(a + b + c));
    }
    static void Main()
    {
        Program p = new Program("a", "b", "c");
        Console.ReadLine();

        
    }
}

    
