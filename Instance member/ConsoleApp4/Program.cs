using System;
class Product
{
    public string ProductName;
    public int ProductPrice;
    public static int TotalProducts = 0;

    public Product(string ProductName, int ProductPrice)
    {
        this.ProductName = ProductName;
        this.ProductPrice = ProductPrice;
        TotalProducts++;
    }
    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total product{TotalProducts}");
    }
    public void DisplayProductinfo()
    {
        Console.WriteLine($"Product name: {ProductName}, Product price: {ProductPrice:C},");
    }
}
class Program
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 12000);
        p1.DisplayProductinfo();
        Product p2 = new Product("KeyBoard",2000);
        p2.DisplayProductinfo();
        Product p3 = new Product("Mouse", 1200);
        p3.DisplayProductinfo();
        Console.WriteLine(Product.TotalProducts);
        Console.ReadLine();    
    }
}