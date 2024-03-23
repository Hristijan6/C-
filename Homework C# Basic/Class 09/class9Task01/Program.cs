namespace class9Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbersQueue = new Queue<int>();

            Console.WriteLine("++++++++++++++++++");

            bool addMoreNumbers = true;
            while (addMoreNumbers)
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    numbersQueue.Enqueue(number);

                    Console.Write("Do you want to enter another number? (Y/N): ");
                    addMoreNumbers = Console.ReadLine().ToLower() == "y";
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine("Numbers you entered:");

            foreach (var num in numbersQueue)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Thank you for using the Number Input App.");
        }
    }
}
