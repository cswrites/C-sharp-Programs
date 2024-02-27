using System;
class Student
{
    public int RollNo;
    public string FirstName;
    public string LastName;
    public int Standard;
    public static string SchoolName = "Pinakeshwar School";

    public void PrintFullName()
    {
        string FullName = this.FirstName + " " + this.LastName;
        Console.WriteLine("Your Full Name is: {0}", FullName);
    }
}
class Program
{
    static void Main()
    {
        Student Karan = new Student();
        Karan.RollNo = 1;
        Karan.FirstName = "Karansingh";
        Karan.LastName = "Chauhan";
        Karan.Standard = 11;

        Console.WriteLine(Karan.RollNo);
        Console.WriteLine(Karan.FirstName);
        Console.WriteLine(Karan.LastName);
        Console.WriteLine(Karan.Standard);
        Karan.PrintFullName();
        Console.WriteLine(Student.SchoolName);
        Console.ReadLine();
    }
}