// Bank Account Program.

using System;

public class BankAccount
{
    private string accountHolder;
    private double balance;

    public BankAccount(string holderName, double initialBalance)
    {
        accountHolder = holderName;
        balance = initialBalance;
    }
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Diposited {amount:C}. New balance: {balance:C}");
    }
    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds!");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Withdarws {amount:C}. New balance: {balance:C}");
        }
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Balance: {balance:C}");
    }
}
    class Program
    {
        static void Main()
        {
            BankAccount myAccount = new BankAccount("John Doe", 1000);
            myAccount.Deposit(500);
            myAccount.Withdraw(200);
            myAccount.DisplayAccountDetails();
            Console.ReadLine();
        }
    }

