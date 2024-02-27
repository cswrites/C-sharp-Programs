/* MyClass has a static variable staticVariable, 
an instance variable instanceVariable, 
and two methods: IncrementStaticVariable (static) and DisplayInstanceVariable (instance).
The Main method demonstrates creating two instances of MyClass, 
calling the static method to increment the static variable, 
and calling instance methods to display the instance variable.
Note how the static variable is shared across all instances of MyClass, 
whereas each instance has its own copy of the instance variable.
*/

using System;
class MyClass
{
    public static int staticVariable = 0;
    private int instanceVariable;

    public MyClass(int value)
    {
        instanceVariable = value;
    }
    public static int IncrementStaticVariable()
    {
       return staticVariable++;
    }
    public void DisplayInstanceVariable()
    {
        Console.WriteLine($"instance varible: {instanceVariable}");
    }
    public static void DisplayStaticVarible()
    {
        Console.WriteLine($"static variable: {staticVariable}");
    }
}
class Program
{
    static void Main()
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = new MyClass(20);

        obj1.DisplayInstanceVariable();
        obj2.DisplayInstanceVariable();

        Console.WriteLine(MyClass.IncrementStaticVariable());

        Console.WriteLine(MyClass.staticVariable);
        Console.ReadLine();
    }
}