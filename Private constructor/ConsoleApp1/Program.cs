using System;
class Example
{
    public static int a;
    private Example()
    {

    }
    public static int getIncerement()
    {
        return ++a;
    }
    //class Example2 : Example
    //{

    //}

    public static void getTime()
    {
        Console.WriteLine(DateTime.Now);
    }
}
class Program
    {
        static void Main()
        {
        Example.a = 20;
        Console.WriteLine(Example.getIncerement());
        //Example e = new Example();
        Example.getTime();
            Console.ReadLine();

        }
    }

