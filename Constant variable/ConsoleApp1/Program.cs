// Temperature Converter

using System;

class Program
{
    static void Main(string[] args)
    {
        const double celsius = 37.5;
        const double conversionFactor = 9.0 / 5.0;
        double farenheit = celsius * conversionFactor + 32;
        Console.WriteLine($"{celsius}C is equal to {farenheit}F");
        Console.ReadLine();
    }
}