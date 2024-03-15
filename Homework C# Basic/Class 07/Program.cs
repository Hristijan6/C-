namespace Class07Exercise01
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input) || !double.TryParse(input, out double number))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                CheckNumber checker = new CheckNumber();
                checker.NumberStats(number);

                while (true)
                {
                    Console.WriteLine("Do you want to enter another number? - Enter y/x");
                    string nextInput = Console.ReadLine().ToLower();

                    if (string.IsNullOrEmpty(nextInput))
                    {
                        Console.WriteLine("Enter a valid input please");
                    }
                    else if (nextInput == "x")
                    {
                        return;
                    }
                    else if (nextInput == "n")
                    {
                        return;
                    }
                    else if (nextInput == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter y/x");
                    }
                }
            }
        }
    }
}
