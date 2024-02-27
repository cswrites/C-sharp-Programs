using System;
class person
{
    public string Name;
    public int Age;

    public person(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
    public string getName()
    {
        return this.Name;
    }
    public int getAge()
    {
        return this.Age;
    }
    ~person()
    {
        Console.WriteLine("Destructor has been invoked !!");
    }
}

class Program
{
    static void Main()
    {
        person p = new person("Karan", 27);
        person p1 = new person("Komal", 23);
        Console.WriteLine(p.getName());
        Console.WriteLine(p.getAge());
        Console.WriteLine("--------------");
        Console.WriteLine(p1.getName());
        Console.WriteLine(p1.getAge());

        //Console.ReadLine();
    }
}