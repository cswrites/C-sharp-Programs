using System;
class Car
{
    public int year;
    public string model;
    public string make;

    public static int TotalCarsProduced = 2;
    public Car(int year, string model, string make)
    {
        this.year = year;
        this.model = model;
        this.make = make;
    }
    public static void DisplayTotalCarsProduced()
    {
        Console.WriteLine($"total cars produced: {TotalCarsProduced}");
    }
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Make: {make}, Model: {model}, Year: {year}");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car(2022,"Corolla","Toyota");
        Car car2 = new Car(2023,"Civic","Honda");

        Console.WriteLine(Car.TotalCarsProduced);
        car1.DisplayCarInfo();
        car2.DisplayCarInfo();
        Console.ReadLine();


    }
}