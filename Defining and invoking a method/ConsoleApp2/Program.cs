using System;
public class MathOperation
{
    public int Add(int a, int b)
    {
        return a + b;

    }
}

class Program
{
    static void Main()
    {
        MathOperation MO = new MathOperation();

        int result = MO.Add(5, 3);

        Console.WriteLine($"Result of addition: {result}");
        Console.ReadLine();

    }

}