﻿namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int swap;

            swap = number1;
            number1 = number2;
            number2 = swap;

            Console.WriteLine($"The first number is {number1} and the second number is {number2}");
        }
    }
}