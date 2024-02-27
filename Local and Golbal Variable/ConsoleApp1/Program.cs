using System;

class Program
{
    static int glo = 6; 

    static void Sum()
    {
        Console.WriteLine(glo);
    }

    static void Main(string[] args)
    {
        int glo = 9;
        glo = 78;
        int a = 4;
        int b = 5;
        float c = 1.78f;
        char x = 'K';
        bool isFalse = false;
        Sum();

        Console.WriteLine($"{glo}{isFalse}");
        Console.WriteLine("\n This is tutorial number 4 and value of a is = " + a + " \n and value of b is = " + b);
        Console.WriteLine("\n The decimal number is = " + c);
        Console.WriteLine("\n The character is = " + x);
        Console.ReadLine();
    }
    
}

/* Note = Wrong Method from c++, 
    - Console.WriteLine(glo + isFalse);
          
In C#, we cannot directly concatenate an integer (glo) with a boolean (isFalse) 
 using the + operator. 
 We need to convert the integer to a string before concatenating it with the boolean. 
 
 #] Here's the corrected line:
    - Console.WriteLine(glo.ToString() + isFalse);
This converts the integer glo to a string before concatenating it with the boolean isFalse.

 #] Alternatively, you can use string interpolation for a more concise syntax:
    - Console.WriteLine($"{glo}{isFalse}");
*/