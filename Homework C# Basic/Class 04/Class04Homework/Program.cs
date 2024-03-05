namespace Class04Homework
{
    internal class SumOfEven
    {
        static void Main(string[] args)
        {
            //exercise 01

            int[] numbers = new int[6];
            int sum = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine($"Sum of even numbers in the array: {sum}");
        }
    }
}
