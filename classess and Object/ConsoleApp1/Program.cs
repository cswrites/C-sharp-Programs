using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

class Student
{
    int rollno;
    string name;
    int age;
    int standard;

    public void setStudent(int rollno, string name, int age, int standard)
    {
        this.rollno = rollno;
        this.name = name;
        this.age = age;
        this.standard = standard;
    }
    public void getStudent()
    {
        
        Console.WriteLine("Your ROLL NO is:{0}" ,this.rollno);
        Console.WriteLine("Your NAME is: {0}", this.name);
        Console.WriteLine("Your AGE is:{0}", this.age);
        Console.WriteLine("Your STANDARD is:{0}", this.standard);
        //Console.ReadLine();
    }
    static void Main()
    {
        Student kc = new Student();
        kc.setStudent(11,"Karan",27,4);
        kc.getStudent();
        Console.ReadLine();

    }
}