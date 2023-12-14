// Practice Lesson 5 Task 5

using System;

public class BankAccount
{
    // Properties
    public string AccountNumber { get; set; }
    public double Balance { get; private set; }

    // Constructor
    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Amount should be greater than 0.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create a bank account with an initial balance
        BankAccount myAccount = new BankAccount("123456789", 1000.00);

        // Deposit money
        myAccount.Deposit(500.00);

        // Withdraw money
        myAccount.Withdraw(200.00);

        // Attempt to withdraw more than the balance
        myAccount.Withdraw(900.00); // This will display an error message

        // Display final balance
        Console.WriteLine($"Final balance: ${myAccount.Balance}");
    }
}
