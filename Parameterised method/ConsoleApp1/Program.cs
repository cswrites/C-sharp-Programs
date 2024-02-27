using System;
class Program
{
    public static void Addition(int x, int y)
    {
        int result = x + y;
        Console.WriteLine("Addition of result is: " +result);
    }
    static void Main()
    {
        Program.Addition(1, 2);
        Program.Addition(11,21);
        Program.Addition(12,22);
        Console.ReadLine();
    }
}