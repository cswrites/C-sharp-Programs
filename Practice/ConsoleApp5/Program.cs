using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Shape
{
    public void CalculateArea()
    {
        Console.WriteLine("Area calculation method from base class Shape");
    }
    public class Rectangle : Shape
    {
    public new void CalculateArea()
        {
            Console.WriteLine("Area calculation method from derived class Rectangle.");
        }
    }
    
    public class Circle : Shape
    {
        public new void CalculateArea()
        {
            Console.WriteLine("Area calculation method from derived class Circle.");
        }
    }
    class Program
    {
        static void Main()
        {
            Shape shape = new Shape();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            Console.WriteLine("Area calculation: ");
            shape.CalculateArea();
            rectangle.CalculateArea();
            circle.CalculateArea();
        }
    }

}