using System;

namespace class3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; 
            int num2;
            string operation;
            bool isValidOperation = false;

            Console.Write("Enter the First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            while (!isValidOperation)
            {
                Console.Write("Enter the Operation (+, -, *, /): ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"The result is: {num1 + num2}");
                        isValidOperation = true;
                        break;
                    case "-":
                        Console.WriteLine($"The result is: {num1 - num2}");
                        isValidOperation = true;
                        break;
                    case "*":
                        Console.WriteLine($"The result is: {num1 * num2}");
                        isValidOperation = true;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            Console.WriteLine($"The result is: {num1 / num2}");
                            isValidOperation = true;
                        }
                        else
                        {
                            Console.WriteLine("Division by zero!!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please enter a valid operation.");
                        break;
                }
            }
        }
    }
}
