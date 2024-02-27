using System;

public class MyClass
{
    public int publicField;
    public int privateField;
    public MyClass()
    {
        publicField = 10;
        privateField = 20;
    }
    public void PublicMethod()
    {
        Console.WriteLine("pUBLIC method called");
    }
    private void PrivateMethod()
    {
        Console.WriteLine("Private method called");
    }
    public void AccessPrivateMethod()
    {
        Console.WriteLine($"Value of privateFGield accessed through public method: {privateField}");
    }
}
class Program
{ 
static void Main(string[] args)
{
    MyClass obj = new MyClass();

    // Accessing public members
    Console.WriteLine($"Value of publicField: {obj.publicField}");
    obj.PublicMethod();

    // Private members are not accessible from outside the class
    // Console.WriteLine($"Value of privateField: {obj.privateField}"); // This would cause a compilation error
    // obj.PrivateMethod(); // This would cause a compilation error

    // Accessing private member through public method
    obj.AccessPrivateMethod();
        Console.ReadLine();

}
}