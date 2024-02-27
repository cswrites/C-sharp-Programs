using System;

class CalculatorProgram
{
    static void Main()
    {
        Console.WriteLine("Simple calculator");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Substraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int oprationSelection = int.Parse(Console.ReadLine());

        switch (oprationSelection)
        {
            case 1:
                Console.WriteLine("You've selected the Addition.");
                PerformAddition();
                break;
            case 2:
                Console.WriteLine("You've selected the Substraction.");
                PerformSubstraction();
                break;
            case 3:
                Console.WriteLine("You've selected the Multiplication.");
                PerformMultiplication();
                break;
            case 4:
                Console.WriteLine("You've selected the Division.");
                PerformDivision();
                break;
            default:
                Console.WriteLine("Invalid operation choice.");
                break;
        }
    }

    static void PerformAddition()
    {
        Console.WriteLine("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the seccound number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 + num2;
        Console.WriteLine($"Result: {result}");
    }

    static void PerformSubstraction()
    {
        Console.WriteLine("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the seccound number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 - num2;
        Console.WriteLine($"Result: {result}");
    }

    static void PerformMultiplication()
    {
        Console.WriteLine("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the seccound number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 * num2;
        Console.WriteLine($"Result: {result}");
    }

    static void PerformDivision()
    {
        Console.WriteLine("Enter the first number: ");
        double dividend = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the seccound number: ");
        double divisor = double.Parse(Console.ReadLine());

        if (divisor != 0)
        {
            double result = dividend / divisor;
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }

    }
}


