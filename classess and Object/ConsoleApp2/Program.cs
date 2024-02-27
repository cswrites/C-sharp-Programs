using System;

class Calculator
{
    //int num1;
    //int num2;

    public int Add(int num1,int num2)
    {
        //a = num1;
        //b = num2;
        return num1 + num2;
    }
    public int substract(int num1, int num2)
    {
        return num1 - num2; ;
    }
    static void Main()
    {
        Calculator calculator = new Calculator();
        int resultAdd = calculator.Add(1,2343);
        Console.WriteLine("Addition: " +resultAdd);
        Console.ReadLine();

    }
}