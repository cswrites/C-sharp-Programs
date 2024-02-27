using System;

class Program
{
       static void PrintMessage(string message, int times)
    {
        for(int i=0; i<times; i++)
        {
            Console.WriteLine(message);
           // Console.ReadLine();
        }

        static void Main()
        {
            PrintMessage("Hello", 5);
            Console.ReadLine();
        }
    }
}