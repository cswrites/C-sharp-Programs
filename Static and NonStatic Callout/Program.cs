using System;
class Myclass
{
    public static void MyStaticmethod()
    {
        Console.WriteLine("This is the static method..");
    }
    public void MyNonStaticMethod()
    {
        Console.WriteLine("This is non static method..");
    }
}
class Program
{    
    static void Main()
    {
        Myclass.MyStaticmethod();
        Myclass MNSM = new Myclass();
        MNSM.MyNonStaticMethod();
        Console.ReadLine();
    }
}