using System;

public class Course
{
    // Instance variables
    private string courseName;
    private string[] materials;

    // Constructor to initialize instance variables
    public Course(string name, string[] initialMaterials)
    {
        courseName = name;
        // Deep copy the array
        materials = new string[initialMaterials.Length];
        Array.Copy(initialMaterials, materials, initialMaterials.Length);
    }

    // Copy constructor
    public Course(Course otherCourse)
    {
        courseName = otherCourse.courseName;
        // Deep copy the array
        materials = new string[otherCourse.materials.Length];
        Array.Copy(otherCourse.materials, materials, otherCourse.materials.Length);
    }

    // Method to display course information
    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Course Name: {courseName}");
        Console.WriteLine("Materials:");
        foreach (string material in materials)
        {
            Console.WriteLine(material);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an array of initial materials
        string[] initialMaterials = { "Lecture slides", "Textbook", "Assignments" };

        // Create a course object
        Course course1 = new Course("Introduction to Programming", initialMaterials);

        // Display information of original course
        Console.WriteLine("Original Course:");
        course1.DisplayCourseInfo();

        // Create a copy of the course using copy constructor
        Course course2 = new Course(course1);

        // Modify materials in original course
        initialMaterials[0] = "Updated lecture slides";

        // Display information of both courses to demonstrate deep copy
        Console.WriteLine("\nAfter modifying materials in the original course:");
        Console.WriteLine("Original Course:");
        course1.DisplayCourseInfo();
        Console.WriteLine("\nCopied Course:");
        course2.DisplayCourseInfo();
    }
}
