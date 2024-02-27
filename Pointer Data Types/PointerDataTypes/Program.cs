/*
ampersand (&): It is Known as Address Operator and use to determine the address of a variable.
asterisk (*): It also known as Indirection Operator and use to access the value of an address.

Syntax->    type* identifier;
Example->       int* p = &a;
 */

using System;

class PointerData
{
    static void Main()
    {
        unsafe
        {

            int a = 10;
            int* b = &a;
            Console.WriteLine("The value of a is = {0)", a);
            Console.WriteLine("The adress of b is = {0}", (int)b);

        }
    }

}
