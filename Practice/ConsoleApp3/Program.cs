using System;
 class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name:{name}, age:{age}");
    }
    public void CelebrateBirthday()
    {
        age++;
        Console.WriteLine($"{name} celebrates their birthday! Now they are {age} years old.");
    }
    static void Main()
    {
        Person person = new Person("Alice", 30);
        person.DisplayInfo();
        person.CelebrateBirthday();
        person.DisplayInfo();
        Console.ReadLine();
    }
    
}