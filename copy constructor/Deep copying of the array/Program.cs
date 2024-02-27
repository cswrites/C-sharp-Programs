/*
create a slightly more complex example using a class that contains an array.
create a copy constructor to ensure deep copying of the array.
*/

/*
Define a ShoppingCart class representing a shopping cart with an array of items.
Create a constructor that takes an array of initial items and a copy constructor to ensure deep copying of the array.
The DisplayCart method is used to display the contents of the shopping cart.
In the Main method, create an initial shopping cart cart1 with some initial items and display its contents.
Then create a copy of cart1 named cart2 using the copy constructor and display its contents.This demonstrates deep copying.
Modify the initial items array outside of the ShoppingCart class to demonstrate that changes to the original array do not affect the copied array.
*/

using System;

public class ShoppingCart
{
    // Instance variables
    private string[] items;

    // Constructor to initialize instance variables
    public ShoppingCart(string[] initialItems)
    {
        // Deep copy the array
        items = new string[initialItems.Length];
        Array.Copy(initialItems, items, initialItems.Length);
    }

    // Copy constructor
    public ShoppingCart(ShoppingCart otherCart)
    {
        // Deep copy the array
        items = new string[otherCart.items.Length];
        Array.Copy(otherCart.items, items, otherCart.items.Length);
    }

    // Method to display shopping cart contents
    public void DisplayCart()
    {
        Console.WriteLine("Shopping Cart Items:");
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a shopping cart with initial items
        string[] initialItems = { "Item 1", "Item 2", "Item 3" };
        ShoppingCart cart1 = new ShoppingCart(initialItems);

        // Displaying contents of the original cart
        Console.WriteLine("Original Shopping Cart:");
        cart1.DisplayCart();

        // Creating a copy of the shopping cart using the copy constructor
        ShoppingCart cart2 = new ShoppingCart(cart1);

        // Displaying contents of the copied cart
        Console.WriteLine("\nCopied Shopping Cart:");
        cart2.DisplayCart();

        // Modifying the original cart
        initialItems[0] = "Modified Item 1";

        // Displaying contents of both carts again to demonstrate deep copy
        Console.WriteLine("\nContents after modifying the initial items array:");
        Console.WriteLine("Original Shopping Cart:");
        cart1.DisplayCart();
        Console.WriteLine("\nCopied Shopping Cart:");
        cart2.DisplayCart();
    }
}
