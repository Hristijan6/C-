using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Customer> customers = new List<Customer>
    {
        new Customer("1234-1234-1234-1234", "4321", "Alice Wonderland", 500),
        new Customer("5678-5678-5678-5678", "9876", "Bob Bobsky", 650)
    };

    static Customer currentCustomer = null;

    static void Main()
    {
        Console.WriteLine("Welcome to the ATM app");

        while (true)
        {
            Console.Write("Please enter your card number: ");
            string cardNumber = Console.ReadLine();

            currentCustomer = customers.FirstOrDefault(c => c.CardNumber == cardNumber);

            if (currentCustomer != null)
            {
                Console.Write("Enter Pin: ");
                string pin = Console.ReadLine();

                if (currentCustomer.Pin == pin)
                {
                    Console.WriteLine($"Welcome {currentCustomer.FullName}!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Pin. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Card Number. Please try again.");
            }
        }

        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Cash Withdrawal");
            Console.WriteLine("3. Cash Deposit");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CheckBalance();
                    break;
                case "2":
                    CashWithdrawal();
                    break;
                case "3":
                    CashDeposit();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the ATM app.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CheckBalance()
    {
        Console.WriteLine($"Your current balance is {currentCustomer.Balance}$");
    }

    static void CashWithdrawal()
    {
        Console.Write("Enter the amount to withdraw: ");
        if (int.TryParse(Console.ReadLine(), out int amount))
        {
            if (currentCustomer.Balance >= amount)
            {
                currentCustomer.Balance -= amount;
                Console.WriteLine($"You withdrew {amount}$. You have {currentCustomer.Balance}$ left on your account.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount. Please try again.");
        }
    }

    static void CashDeposit()
    {
        Console.Write("Enter the amount to deposit: ");
        if (int.TryParse(Console.ReadLine(), out int amount))
        {
            currentCustomer.Balance += amount;
            Console.WriteLine($"You deposited {amount}$. Your new balance is {currentCustomer.Balance}$.");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please try again.");
        }
    }
}
