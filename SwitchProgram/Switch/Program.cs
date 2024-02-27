/* Syntax
switch (expression)
 {
case value1: // statement sequence
             break;.
.
.
case valueN: // statement sequence
             break;
default: // default statement sequence
}
*/

using System;
 class SwitchPorg
{
    static void Main()
    {
        int num = 3;
        switch(num)
        {
            case 1: Console.WriteLine("Case 1");
                break;
            case 2: Console.WriteLine("Case 2");
                break;
            case 3: Console.WriteLine("Case 3");
                break;
            default: Console.WriteLine("No matches");
                break;
        }
    }
}